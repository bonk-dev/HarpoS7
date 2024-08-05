using System.Buffers;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using CommunityToolkit.HighPerformance.Buffers;
using HarpoS7.Aes;
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
    private static readonly ArrayPool<byte> AesKeyPool = ArrayPool<byte>.Create(16, 3);
    
    // TODO: This API will most likely change
    
    [Experimental("familyZero")]
    public static void AuthenticateFamilyZero(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey)
    {
        if (encryptedBlobData.Length < CommonConstants.EncryptedBlobLengthFamilyZero)
        {
            throw new ArgumentException($"Encrypted blob data must be at least {CommonConstants.EncryptedBlobLengthFamilyZero} bytes long",
                nameof(encryptedBlobData));
        }
        
        Span<byte> key1 = stackalloc byte[24];
        key1.FillWithCryptoRandomBytes();

        #region Metadata

        var offset = BlobMetadataWriter.WriteMetadata(
            encryptedBlobData, 
            publicKey, 
            key1, 
            EPublicKeyFamily.Family0
        );

        #endregion

        #region Seed

        Span<byte> t1 = stackalloc byte[Transform1.DestinationSize];
        Transform1.Execute(t1, key1);
        Transform6.Execute(encryptedBlobData[offset..], publicKey, t1);
        offset += Transform1.DestinationSize;
        
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

        const int challengeEncryptionKeyLength = 128 / 8;
        var challengeEncryptionKey = AesKeyPool.Rent(challengeEncryptionKeyLength);
        transform2Buffer[..challengeEncryptionKeyLength].CopyTo(challengeEncryptionKey);
        
        #endregion
        
        try
        {
            #region Challenge encryption
            
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.KeySize = 128;
            aes.Key = challengeEncryptionKey;

            const int encryptedChallengeLength = 16;
            Span<byte> encryptedChallenge = stackalloc byte[encryptedChallengeLength];

            aes.EncryptCfb(
                challenge.Slice(2, encryptedChallengeLength),
                aesIv,
                encryptedChallenge,
                PaddingMode.Zeros,
                feedbackSizeInBits: 128
            );

            encryptedChallenge.CopyTo(encryptedBlobData[offset..]);

            #endregion

            throw new NotImplementedException("Part2 encryption is not yet implemented");
        }
        finally
        {
            // I think it is a good practise to clear encryption keys
            AesKeyPool.Return(challengeEncryptionKey, clearArray: true);
        }
    }

    public static void Authenticate(
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

#if DEBUG
        key1.Fill(0x11);
        key2.Fill(0x22);
#else
        RandomNumberGenerator.Fill(key1);
        RandomNumberGenerator.Fill(key2);
#endif

        // 2. Derive the challenge encryption key
        Span<byte> challengeKey = stackalloc byte[CommonConstants.AesKeyLengthInBytes];
        KeyUtilities.DeriveChallengeEncryptionKey(challengeKey, key2);

        // 3. Generate IV for challenge encryption
        Span<byte> ivBuffer = stackalloc byte[CommonConstants.AesIvLength];

#if DEBUG
        ivBuffer.Fill(0xCC);
#else
        RandomNumberGenerator.Fill(ivBuffer);
#endif

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