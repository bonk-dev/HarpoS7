using System.Buffers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using CommunityToolkit.HighPerformance.Buffers;
using HarpoS7.Family0.BitOperations;
using HarpoS7.Family0.Transforms;
using HarpoS7.Utilities.Auth;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Family0.Auth;

public class RealPlcAuthenticator : IDisposable
{
    private static readonly ArrayPool<byte> AesKeyPool = ArrayPool<byte>.Create(16, 2);

    private const PaddingMode Padding = PaddingMode.None;

    private readonly MemoryOwner<byte> _iv;
    private readonly MemoryOwner<byte> _key1;
    private readonly MemoryOwner<byte> _key2;
    private readonly MemoryOwner<byte> _lookupTable;
    private readonly MemoryOwner<byte> _checksum;
    private readonly byte[] _challengeEncryptionKey;
    private readonly byte[] _checksumEncryptionKey;
    private readonly Aes _aes;

    private int _encryptedBytes;

    public int Key2LeftOverLength => _key2.Length % (_aes.BlockSize / 8);

    public RealPlcAuthenticator(
        ReadOnlySpan<byte> key1 = default, 
        ReadOnlySpan<byte> key2 = default)
    {
        _iv = MemoryOwner<byte>.Allocate(16);
        _key1 = MemoryOwner<byte>.Allocate(24);

        if (key2.IsEmpty)
        {
            _key2 = MemoryOwner<byte>.Allocate(24);
            _key2.Span.FillWithCryptoRandomBytes();
        }
        else
        {
            _key2 = MemoryOwner<byte>.Allocate(key2.Length);
            key2.CopyTo(_key2.Span);
        }
        
        _lookupTable = MemoryOwner<byte>.Allocate(LutGenerator.DestinationSize);
        _checksum = MemoryOwner<byte>.Allocate(16);

        if (key1.IsEmpty)
        {
            _key1.Span.FillWithCryptoRandomBytes();
        }
        else
        {
            key1.CopyTo(_key1.Span);
        }

        _iv.Span.FillWithCryptoRandomBytes();

        _aes = Aes.Create();
        _aes.Padding = Padding;
        _aes.KeySize = 128;

        _challengeEncryptionKey = AesKeyPool.Rent(_aes.KeySize / 8);
        _checksumEncryptionKey = AesKeyPool.Rent(_aes.KeySize / 8);
    }

    public int WriteMetadata(Span<byte> destination, ReadOnlySpan<byte> publicKey, EPublicKeyFamily keyFamily)
    {
        if (keyFamily != EPublicKeyFamily.S71200 && keyFamily != EPublicKeyFamily.S71500)
        {
            throw new ArgumentException(
                $"{Enum.GetName(keyFamily)} is not supported by this authenticator", 
                nameof(keyFamily)
            );
        }
        
        var offset = BlobMetadataWriter.WriteMetadata(
            destination, 
            publicKey,
            _key2.Span, 
            keyFamily
        );

        return offset;
    }

    public int WriteSeed(Span<byte> destination, ReadOnlySpan<byte> publicKey)
    {
        var offset = 0;
        
        // Seed
        Span<byte> t1 = stackalloc byte[PreSeedTransform.DestinationSize];
        PreSeedTransform.Execute(t1, _key1.Span);
        SeedTransform.Execute(destination[offset..], publicKey, t1);
        offset += SeedTransform.DestinationSize;
        
        // Keys derivation
        DeriveKeysAndLookupTable(t1);
        
        // Checksum
        ChecksumTransform.Execute(_checksum.Span, _iv.Span, _lookupTable.Span);

        return offset;
    }

    public int EncryptFullBlocks(Span<byte> destination, ReadOnlySpan<byte> challenge)
    {
        // Copy the starting IV
        var offset = 0;
        _iv.Span.CopyTo(destination[offset..]);
        offset += _iv.Length;
        
        // Encrypt 16 bytes of challenge
        Span<byte> ciphertextBlock = stackalloc byte[_aes.BlockSize / 8];
        
        _aes.EncryptEcb(
            _iv.Span,
            ciphertextBlock,
            Padding
        );
        ciphertextBlock.Xor(challenge.Slice(2, ciphertextBlock.Length));
        ciphertextBlock.CopyTo(destination[offset..]);
        offset += ciphertextBlock.Length;
        _encryptedBytes += ciphertextBlock.Length;
        
        // Rotate IV
        BigIntOperations.RotateLeft31(_iv.Span);
        UpdateChecksum(ciphertextBlock);

        // Encrypt all full blocks (16 byte chunks) of _key2
        for (var i = 0; i < _key2.Length / 16; ++i)
        {
            _aes.EncryptEcb(
                _iv.Span,
                ciphertextBlock,
                Padding
            );
            ciphertextBlock.Xor(_key2.Span.Slice(i * 16, ciphertextBlock.Length));
            ciphertextBlock.CopyTo(destination[offset..]);
            offset += ciphertextBlock.Length;
            _encryptedBytes += ciphertextBlock.Length;

            // Rotate IV
            BigIntOperations.RotateLeft31(_iv.Span);
            UpdateChecksum(ciphertextBlock);
        }

        return offset;
    }

    public int EncryptFinalBlock(Span<byte> destination)
    {
        Span<byte> ciphertextBlock = stackalloc byte[_aes.BlockSize / 8];
        
        // Encrypt partial key2 block
        
        var leftOverStartIndex = _key2.Length - Key2LeftOverLength;
        
        _aes.EncryptEcb(
            _iv.Span, 
            ciphertextBlock, 
            Padding
        );
        ciphertextBlock.Xor(_key2.Span.Slice(leftOverStartIndex, Key2LeftOverLength));
        
        ciphertextBlock[..Key2LeftOverLength].CopyTo(destination);
        _encryptedBytes += Key2LeftOverLength;
        var offset = Key2LeftOverLength;
        
        // Final checksum calculation & encryption
        ciphertextBlock[Key2LeftOverLength..].Clear();
        
        UpdateChecksum(ciphertextBlock);
            
        var checksumDwords = MemoryMarshal.Cast<byte, uint>(_checksum.Span);
        checksumDwords[3] ^= (uint)_encryptedBytes;
        
        ChecksumTransform.Execute(_checksum.Span, _checksum.Span, _lookupTable.Span);

        _aes.Key = _checksumEncryptionKey;
        _aes.EncryptEcb(
            _checksum.Span,
            ciphertextBlock,
            PaddingMode.Zeros
        );

        // Copy the final checksum
        ciphertextBlock.CopyTo(destination[offset..]);
        offset += ciphertextBlock.Length;

        return offset;
    }

    /// <summary>
    /// Writes the generated key2 to the specified buffer. Key2 is used for the derivation of the session key.
    /// </summary>
    /// <param name="destination">The key2 buffer</param>
    public void ExtractKey2(Span<byte> destination) => 
        _key2.Span.CopyTo(destination);

    private void DeriveKeysAndLookupTable(ReadOnlySpan<byte> t1)
    {
        // Generates 3, 128-bit keys
        Span<byte> transform2Buffer = stackalloc byte[KeyDerivationTransform.DestinationSize];
        KeyDerivationTransform.Execute(transform2Buffer, t1);

        // Challenge encryption key
        const int challengeEncryptionKeyLength = 128 / 8;
        transform2Buffer[..challengeEncryptionKeyLength].CopyTo(_challengeEncryptionKey.AsSpan());

        _aes.Key = _challengeEncryptionKey;

        // Checksum encryption key
        const int checksumEncryptionLength = 128 / 8;
        transform2Buffer.Slice(challengeEncryptionKeyLength, checksumEncryptionLength)
            .CopyTo(_checksumEncryptionKey.AsSpan());
        
        // Create the lookup table
        LutGenerator.Execute(_lookupTable.Span, transform2Buffer[32..]);
    }

    private void UpdateChecksum(ReadOnlySpan<byte> ciphertextBlock)
    {
        _checksum.Span.Xor(ciphertextBlock);
        ChecksumTransform.Execute(_checksum.Span, _checksum.Span, _lookupTable.Span);
    }

    public void Dispose()
    {
        _iv.Dispose();
        _key1.Dispose();
        _key2.Dispose();
        _lookupTable.Dispose();
        _checksum.Dispose();
        _aes.Dispose();
    }
}