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

    public RealPlcAuthenticator()
    {
        _iv = MemoryOwner<byte>.Allocate(16);
        _key1 = MemoryOwner<byte>.Allocate(24);
        _key2 = MemoryOwner<byte>.Allocate(24);
        _lookupTable = MemoryOwner<byte>.Allocate(Transform3.DestinationSize);
        _checksum = MemoryOwner<byte>.Allocate(16);
        
        _key1.Span.FillWithCryptoRandomBytes();
        _key2.Span.FillWithCryptoRandomBytes();
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
        Span<byte> t1 = stackalloc byte[Transform1.DestinationSize];
        Transform1.Execute(t1, _key1.Span);
        Transform6.Execute(destination[offset..], publicKey, t1);
        offset += Transform6.DestinationSize;
        
        // Keys derivation
        DeriveKeysAndLookupTable(t1);
        
        // Checksum
        Transform4.Execute(_checksum.Span, _iv.Span, _lookupTable.Span);

        return offset;
    }

    public int EncryptPart1(Span<byte> destination, ReadOnlySpan<byte> challenge)
    {
        // Copy the starting IV
        var offset = 0;
        _iv.Span.CopyTo(destination[offset..]);
        offset += _iv.Length;
        
        // Encrypt 16 bytes of challenge
        Span<byte> ciphertextBlock = stackalloc byte[_aes.BlockSize / 8];
        // challenge.Slice(2, ciphertextBlock.Length).CopyTo(ciphertextBlock);
        
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
        
        // Encrypt first 16 bytes of key2
        _aes.EncryptEcb(
            _iv.Span,
            ciphertextBlock,
            Padding
        );
        ciphertextBlock.Xor(_key2.Span[..ciphertextBlock.Length]);
        ciphertextBlock.CopyTo(destination[offset..]);
        offset += ciphertextBlock.Length;
        _encryptedBytes += ciphertextBlock.Length;
        
        // Rotate IV
        BigIntOperations.RotateLeft31(_iv.Span);
        UpdateChecksum(ciphertextBlock);

        return offset;
    }

    public int EncryptPart2(Span<byte> destination)
    {
        Span<byte> ciphertextBlock = stackalloc byte[_aes.BlockSize / 8];
        
        // Encrypt last 8 bytes of key2
        _aes.EncryptEcb(
            _iv.Span, 
            ciphertextBlock, 
            Padding
        );
        ciphertextBlock.Xor(_key2.Span[ciphertextBlock.Length..]);
        
        var key2LeftOverLength = _key2.Span.Length - ciphertextBlock.Length;
        ciphertextBlock[..key2LeftOverLength].CopyTo(destination);
        _encryptedBytes += key2LeftOverLength;
        var offset = key2LeftOverLength;
        
        // Final checksum calculation & encryption
        ciphertextBlock[key2LeftOverLength..].Clear();
        
        UpdateChecksum(ciphertextBlock);
            
        var checksumDwords = MemoryMarshal.Cast<byte, uint>(_checksum.Span);
        checksumDwords[3] ^= (uint)_encryptedBytes;
        
        Transform4.Execute(_checksum.Span, _checksum.Span, _lookupTable.Span);

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
    /// Writes the generated key1 to the specified buffer. Key1 is used for the derivation of the session key.
    /// </summary>
    /// <param name="destination">The key1 buffer</param>
    public void ExtractKey1(Span<byte> destination) => 
        _key1.Span.CopyTo(destination);

    private void DeriveKeysAndLookupTable(ReadOnlySpan<byte> t1)
    {
        // Generates 3, 128-bit keys
        Span<byte> transform2Buffer = stackalloc byte[Transform2.DestinationSize];
        Transform2.Execute(transform2Buffer, t1);

        // Challenge encryption key
        const int challengeEncryptionKeyLength = 128 / 8;
        transform2Buffer[..challengeEncryptionKeyLength].CopyTo(_challengeEncryptionKey.AsSpan());

        _aes.Key = _challengeEncryptionKey;

        // Checksum encryption key
        const int checksumEncryptionLength = 128 / 8;
        transform2Buffer.Slice(challengeEncryptionKeyLength, checksumEncryptionLength)
            .CopyTo(_checksumEncryptionKey.AsSpan());
        
        // Create the lookup table
        Transform3.Execute(_lookupTable.Span, transform2Buffer[32..]);
    }

    private void UpdateChecksum(ReadOnlySpan<byte> ciphertextBlock)
    {
        _checksum.Span.Xor(ciphertextBlock);
        Transform4.Execute(_checksum.Span, _checksum.Span, _lookupTable.Span);
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