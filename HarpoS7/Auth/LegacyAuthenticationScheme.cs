using System.Security.Cryptography;
using CommunityToolkit.HighPerformance.Buffers;
using HarpoS7.Aes;
using HarpoS7.Extensions;
using HarpoS7.Keys;
using HarpoS7.Seed;

namespace HarpoS7.Auth;

/// <summary>
/// Pre-TLS authentication scheme
/// </summary>
public static class LegacyAuthenticationScheme
{
    private const int AesKeyLengthInBytes = 128 / 8;
    private const int AesIvLength = 16;
    private const int EncryptedSeedLength = 96;

    public const int EncryptedBlobLength = 216;

    public static void Authenticate(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey)
    {
        // so i dont forget - sessionkey, the one for calculating packet digests, is calculated using 0x11 key
        if (encryptedBlobData.Length < EncryptedBlobLength)
        {
            throw new ArgumentException($"Encrypted blob data must be at least {EncryptedBlobLength} bytes long",
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
        Span<byte> challengeKey = stackalloc byte[AesKeyLengthInBytes];
        KeyUtilities.DeriveChallengeEncryptionKey(challengeKey, key2);

        // 3. Generate IV for challenge encryption
        Span<byte> ivBuffer = stackalloc byte[AesIvLength];

#if DEBUG
        ivBuffer.Fill(0xCC);
#else
        RandomNumberGenerator.Fill(ivBuffer);
#endif

        // 4. Write metadata
        int blobIndex = WriteEncryptedBlobMetadata(encryptedBlobData, publicKey, key1);

        // 5. Generate and encrypt seed
        HarpoSeedUtilities.GenerateEncryptedSeed(
            encryptedBlobData.Slice(blobIndex, EncryptedSeedLength),
            publicKey,
            challengeKey);
        blobIndex += EncryptedSeedLength;

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

    /// <summary>
    /// Writes encrypted blob metadata
    /// </summary>
    /// <param name="blobData">The output</param>
    /// <param name="publicKey">The used public key</param>
    /// <param name="key1">The key used for deriving session key</param>
    /// <returns>Next writeable offset in <paramref name="blobData"/></returns>
    private static int WriteEncryptedBlobMetadata(
        Span<byte> blobData,
        ReadOnlySpan<byte> publicKey,
        ReadOnlySpan<byte> key1)
    {
        const uint BlobMagic = 0xFEE1DEAD;

        var blobDword = blobData.AsDwords();
        blobDword[0] = BlobMagic;
        blobDword[1] = EncryptedBlobLength;
        blobDword[2] = 1;
        blobDword[3] = 1;

        key1.DeriveKeyId(blobData[(sizeof(uint) * 4)..]);
        blobDword[6] = 769;
        blobDword[7] = 0;

        publicKey.DeriveKeyId(blobData[(sizeof(uint) * 8)..]);
        blobDword[10] = 784;
        blobDword[11] = 0;

        return 12 * sizeof(uint);
    }
}