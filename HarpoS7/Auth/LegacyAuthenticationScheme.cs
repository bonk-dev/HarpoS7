using HarpoS7.Aes;
using HarpoS7.Family0.Auth;
using HarpoS7.Utilities.Extensions;
using HarpoS7.Keys;
using HarpoS7.Seed;
using HarpoS7.Utilities.Auth;

namespace HarpoS7.Auth;

/// <summary>
/// Pre-TLS authentication scheme
/// </summary>
public static class LegacyAuthenticationScheme
{
    public static void Authenticate(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey,
        EPublicKeyFamily publicKeyFamily)
    {
        switch (publicKeyFamily)
        {
            case EPublicKeyFamily.S71500:
            case EPublicKeyFamily.S71200:
                AuthenticateRealPlc(encryptedBlobData, sessionKey, challenge, publicKey, publicKeyFamily);
                break;
            case EPublicKeyFamily.PlcSim:
                AuthenticatePlcSim(encryptedBlobData, sessionKey, challenge, publicKey);
                break;
            default:
                throw new ArgumentException("Unsupported key family", nameof(publicKeyFamily));
        }
    }
    
    public static void AuthenticateRealPlc(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey,
        EPublicKeyFamily publicKeyFamily)
    {
        if (publicKeyFamily != EPublicKeyFamily.S71500 && publicKeyFamily != EPublicKeyFamily.S71200)
        {
            throw new ArgumentException(
                "This function can be used only with family0 and family1 keys", 
                nameof(publicKeyFamily)
            );
        }
        
        if (encryptedBlobData.Length < CommonConstants.EncryptedBlobLengthRealPlc)
        {
            throw new ArgumentException($"Encrypted blob data must be at least {CommonConstants.EncryptedBlobLengthRealPlc} bytes long",
                nameof(encryptedBlobData));
        }

        var authenticator = new RealPlcAuthenticator();
        var offset = authenticator.WriteMetadata(encryptedBlobData, publicKey, publicKeyFamily);
        offset += authenticator.WriteSeed(encryptedBlobData[offset..], publicKey);
        offset += authenticator.EncryptPart1(encryptedBlobData[offset..], challenge);
        _ = authenticator.EncryptPart2(encryptedBlobData[offset..]);

        Span<byte> key1 = stackalloc byte[24];
        authenticator.ExtractKey1(key1);

        KeyUtilities.DeriveSessionKey(sessionKey, key1, challenge);
    }

    public static void AuthenticatePlcSim(
        Span<byte> encryptedBlobData,
        Span<byte> sessionKey,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey)
    {
        // so i dont forget - sessionkey, the one for calculating packet digests, is calculated using 0x11 key
        if (encryptedBlobData.Length < CommonConstants.EncryptedBlobLengthPlcSim)
        {
            throw new ArgumentException($"Encrypted blob data must be at least {CommonConstants.EncryptedBlobLengthPlcSim} bytes long",
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
        int blobIndex = BlobMetadataWriter.WriteMetadata(encryptedBlobData, publicKey, key1, EPublicKeyFamily.PlcSim);

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