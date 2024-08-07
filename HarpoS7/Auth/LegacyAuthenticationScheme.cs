using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using HarpoS7.Aes;
using HarpoS7.Family0.BitOperations;
using HarpoS7.Family0.Transforms;
using HarpoS7.Utilities.Extensions;
using HarpoS7.Keys;
using HarpoS7.Seed;

namespace HarpoS7.Auth;

/// <summary>
/// Pre-TLS authentication scheme
/// </summary>
public static class LegacyAuthenticationScheme
{
    private static readonly ArrayPool<byte> AesKeyPool = ArrayPool<byte>.Create(16, 2);

    public static void Authenticate(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey,
        EPublicKeyFamily publicKeyFamily)
    {
        switch (publicKeyFamily)
        {
            case EPublicKeyFamily.Family0:
            case EPublicKeyFamily.Family1:
                AuthenticateFamilyZero(encryptedBlobData, sessionKey, challenge, publicKey, publicKeyFamily);
                break;
            case EPublicKeyFamily.Family3:
                AuthenticateFamilyThree(encryptedBlobData, sessionKey, challenge, publicKey);
                break;
            default:
                throw new ArgumentException("Unsupported key family", nameof(publicKeyFamily));
        }
    }
    
    public static void AuthenticateFamilyZero(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey,
        EPublicKeyFamily publicKeyFamily)
    {
        if (publicKeyFamily != EPublicKeyFamily.Family0 && publicKeyFamily != EPublicKeyFamily.Family1)
        {
            throw new ArgumentException(
                "This function can be used only with family0 and family1 keys", 
                nameof(publicKeyFamily)
            );
        }
        
        if (encryptedBlobData.Length < CommonConstants.EncryptedBlobLengthFamilyZero)
        {
            throw new ArgumentException($"Encrypted blob data must be at least {CommonConstants.EncryptedBlobLengthFamilyZero} bytes long",
                nameof(encryptedBlobData));
        }

        Span<byte> challengeBuffer = stackalloc byte[16];
        challenge.Slice(2, challengeBuffer.Length).CopyTo(challengeBuffer);
        
        Span<byte> key1 = stackalloc byte[24];
        key1.FillWithCryptoRandomBytes();
        
        Span<byte> key2 = stackalloc byte[24];
        key2.FillWithCryptoRandomBytes();

        #region Metadata

        var offset = BlobMetadataWriter.WriteMetadata(
            encryptedBlobData, 
            publicKey, 
            key2, 
            publicKeyFamily
        );

        #endregion

        #region Seed

        Span<byte> t1 = stackalloc byte[Transform1.DestinationSize];
        Transform1.Execute(t1, key1);
        Transform6.Execute(encryptedBlobData[offset..], publicKey, t1);
        offset += Transform6.DestinationSize;
        
        #endregion

        #region IV

        Span<byte> aesIv = stackalloc byte[16];
        aesIv.FillWithCryptoRandomBytes();
        aesIv.CopyTo(encryptedBlobData[offset..]);
        offset += aesIv.Length;
        
        #endregion

        #region Key generation

        // Generates 3, 128-bit keys
        Span<byte> transform2Buffer = stackalloc byte[Transform2.DestinationSize];
        Transform2.Execute(transform2Buffer, t1);

        // Challenge encryption key (CEK)
        const int challengeEncryptionKeyLength = 128 / 8;
        var challengeEncryptionKey = AesKeyPool.Rent(challengeEncryptionKeyLength);
        transform2Buffer[..challengeEncryptionKeyLength].CopyTo(challengeEncryptionKey.AsSpan());

        const int checksumEncryptionLength = 128 / 8;
        var checksumEncryptionKey = AesKeyPool.Rent(checksumEncryptionLength);
        transform2Buffer.Slice(challengeEncryptionKeyLength, checksumEncryptionLength)
            .CopyTo(checksumEncryptionKey.AsSpan());

        // Checksum
        Span<byte> lookupTable = stackalloc byte[Transform3.DestinationSize];
        Transform3.Execute(lookupTable, transform2Buffer[32..]);
        Span<byte> checksum = stackalloc byte[Transform4.DestinationSize];
        Transform4.Execute(checksum, aesIv, lookupTable);
        
        #endregion
        
        try
        {
            #region Challenge encryption
            
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.KeySize = 128;
            aes.Key = challengeEncryptionKey;

            const int encryptedChallengeLength = 16;
            Span<byte> blockCiphertext = stackalloc byte[encryptedChallengeLength];
            
            aes.EncryptEcb(
                aesIv,
                blockCiphertext,
                PaddingMode.Zeros
            );
            blockCiphertext.Xor(challengeBuffer);

            blockCiphertext.CopyTo(encryptedBlobData[offset..]);
            offset += blockCiphertext.Length;
            
            // IV gets carry-rotated after every encryption
            BigIntOperations.RotateLeft31(aesIv);
            
            // XOR checksum with enc. challenge
            checksum.Xor(blockCiphertext);
            Transform4.Execute(checksum, checksum, lookupTable);

            #endregion

            #region Key2 encryption

            // Encrypt key2
            aes.EncryptEcb( 
                aesIv, 
                blockCiphertext,
                PaddingMode.Zeros
            );
            blockCiphertext.Xor(key2[..(aes.BlockSize / 8)]);
            
            blockCiphertext.CopyTo(encryptedBlobData[offset..]);
            offset += blockCiphertext.Length;
            
            BigIntOperations.RotateLeft31(aesIv);
            
            checksum.Xor(blockCiphertext);
            Transform4.Execute(checksum, checksum, lookupTable);

            #endregion

            #region Key 2 encryption part 2
            
            var key2LeftOverLength = key2.Length - blockCiphertext.Length;
            
            // Replace first 8 bytes of the challenge with last 8 bytes of key2 
            key2.Slice(16, key2LeftOverLength).CopyTo(challengeBuffer);

            // Encrypt last 8 bytes of key2
            // ==============================
            // This is done because the AES block size is 16 bytes and not 24 bytes
            // If the original implementation actually used AES-CFB, we would be able to just EncryptCfb
            // the entire key2 at once, but they are rotating the IV instead 
            aes.EncryptEcb(
                aesIv,
                blockCiphertext,
                PaddingMode.Zeros
            );
            blockCiphertext.Xor(challengeBuffer);
            
            blockCiphertext[..key2LeftOverLength].CopyTo(encryptedBlobData[offset..]);
            offset += key2LeftOverLength;

            #endregion

            #region Checksum
            
            blockCiphertext[key2LeftOverLength..].Clear();
            checksum.Xor(blockCiphertext);
            Transform4.Execute(checksum, checksum, lookupTable);
            
            var encryptedBytes = encryptedChallengeLength + key2.Length;
            var checksumDwords = MemoryMarshal.Cast<byte, uint>(checksum);
            checksumDwords[3] ^= (uint)encryptedBytes;
            
            Transform4.Execute(checksum, checksum, lookupTable);

            aes.Key = checksumEncryptionKey;
            aes.EncryptEcb(
                checksum,
                blockCiphertext,
                PaddingMode.Zeros
            );

            // Copy the final checksum
            blockCiphertext.CopyTo(encryptedBlobData[offset..]);
            
            #endregion
        }
        finally
        {
            // I think it is a good practise to clear encryption keys
            AesKeyPool.Return(challengeEncryptionKey, clearArray: true);
            AesKeyPool.Return(checksumEncryptionKey, clearArray: true);
        }
        
        KeyUtilities.DeriveSessionKey(sessionKey, key1, challenge);
    }

    public static void AuthenticateFamilyThree(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey)
    {
        // so i dont forget - sessionkey, the one for calculating packet digests, is calculated using 0x11 key
        if (encryptedBlobData.Length < CommonConstants.EncryptedBlobLengthFamilyThree)
        {
            throw new ArgumentException($"Encrypted blob data must be at least {CommonConstants.EncryptedBlobLengthFamilyThree} bytes long",
                nameof(encryptedBlobData));
        }

        // 1. Generate two random 24 byte keys
        Span<byte> key1 = stackalloc byte[24];
        Span<byte> key2 = stackalloc byte[24];
        
        key1.FillWithCryptoRandomBytes();
        key2.FillWithCryptoRandomBytes();

        // 2. Derive the challenge encryption key
        Span<byte> challengeKey = stackalloc byte[CommonConstants.AesKeyLengthInBytes];
        KeyUtilities.DeriveChallengeEncryptionKey(challengeKey, key2);

        // 3. Generate IV for challenge encryption
        Span<byte> ivBuffer = stackalloc byte[CommonConstants.AesIvLength];
        ivBuffer.FillWithCryptoRandomBytes();

        // 4. Write metadata
        int blobIndex = BlobMetadataWriter.WriteMetadata(encryptedBlobData, publicKey, key1, EPublicKeyFamily.Family3);

        // 5. Generate and encrypt seed
        HarpoSeedUtilities.GenerateEncryptedSeed(
            encryptedBlobData.Slice(blobIndex, CommonConstants.EncryptedSeedLength),
            publicKey,
            challengeKey);
        blobIndex += CommonConstants.EncryptedSeedLength;

        // 6. Write IV
        ivBuffer.CopyTo(encryptedBlobData[blobIndex..]);
        blobIndex += 16;

        // 7. Initialize AES-CTR
        using var aes = new HarpoAesCtr(challengeKey);
        aes.Init(ivBuffer);

        // 8. Encrypt challenge (skipping 2 first bytes, and 2 last ones)
        aes.EncryptCtr(challenge.Slice(2, 16), encryptedBlobData[blobIndex..]);
        blobIndex += 16;

        // 9. Encrypt key1 (used to derive the session key, which is used
        //    for calculating packet digests after authentication)
        aes.EncryptCtr(key1, encryptedBlobData[blobIndex..]);
        blobIndex += 24;

        // 10. Calculate the AES-CTR checksum
        aes.CalculateChecksum(encryptedBlobData.Slice(blobIndex, 16));

        // 10. Calculate the session key
        KeyUtilities.DeriveSessionKey(sessionKey, key1, challenge);
    }
}