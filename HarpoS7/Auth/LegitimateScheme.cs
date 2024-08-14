using System.Buffers.Binary;
using System.Security.Cryptography;
using System.Text;
using HarpoS7.Aes;
using HarpoS7.Family0.Auth;
using HarpoS7.Utilities.Extensions;
using HarpoS7.Keys;
using HarpoS7.Seed;
using HarpoS7.Utilities.Auth;

namespace HarpoS7.Auth;

public static class LegitimateScheme
{
    internal const int BeefFragmentMetadataLength = 0x0C;
    private const uint DeadBeefMagic = 0xDEADBEEF;

    private const int BlobLengthOffset = 68;
    public const int OutputBlobDataLengthRealPlc = CommonConstants.EncryptedBlobLengthRealPlc + BlobLengthOffset;
    public const int OutputBlobDataLengthPlcSim = CommonConstants.EncryptedBlobLengthPlcSim + BlobLengthOffset;
    public const int ChallengeLength = 20;

    /// <summary>
    /// Solve the legitimation challenge to be able to communicate with PLCs that require a password.
    /// </summary>
    /// <param name="blobDataDestination">Blob data output for SetVarSubStreamed</param>
    /// <param name="challenge">Challenge from GetVarSubStreamed</param>
    /// <param name="publicKey">Public key required by PLC</param>
    /// <param name="sessionKey">Session key generated in the earlier authentication stage</param>
    /// <param name="password">The password</param>
    /// <exception cref="ArgumentException"></exception>
    public static void SolveLegitimateChallengeRealPlc(
        Span<byte> blobDataDestination,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey,
        ReadOnlySpan<byte> sessionKey,
        string password)
    {
        var length = Encoding.UTF8.GetByteCount(password);
        Span<byte> passBytes = stackalloc byte[length];
        Encoding.UTF8.GetBytes(password, passBytes);
        
        Span<byte> hash = stackalloc byte[SHA1.HashSizeInBytes];
        _ = SHA1.HashData(passBytes, hash);
        
        SolveLegitimateChallengeRealPlc(
            blobDataDestination, 
            challenge, 
            publicKey,
            sessionKey, 
            hash);
    }

    /// <summary>
    /// Solve the legitimation challenge to be able to communicate with PLCs that require a password.
    /// </summary>
    /// <param name="blobDataDestination">Blob data output for SetVarSubStreamed</param>
    /// <param name="challenge">Challenge from GetVarSubStreamed</param>
    /// <param name="publicKey">Public key required by PLC</param>
    /// <param name="sessionKey">Session key generated in the earlier authentication stage</param>
    /// <param name="passwordHash">SHA-1 hash of the access password</param>
    /// <exception cref="ArgumentException"></exception>
    public static void SolveLegitimateChallengeRealPlc(
        Span<byte> blobDataDestination,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey,
        ReadOnlySpan<byte> sessionKey,
        ReadOnlySpan<byte> passwordHash)
    {
        if (blobDataDestination.Length < OutputBlobDataLengthRealPlc)
        {
            throw new ArgumentException($"BlobDataDestination must be at least {OutputBlobDataLengthRealPlc} bytes long",
                nameof(blobDataDestination));
        }

        if (passwordHash.Length < SHA1.HashSizeInBytes)
        {
            throw new ArgumentException("Password hash is not a SHA1 (too short)", nameof(passwordHash));
        }

        if (challenge.Length < ChallengeLength)
        {
            throw new ArgumentException($"Challenge must be at least {ChallengeLength} bytes long",
                nameof(challenge));
        }

        throw new NotImplementedException("Real PLC (Family0/1) legitimation is not yet implemented");
    }

    /// <summary>
    /// Solve the legitimation challenge to be able to communicate with PLCs that require a password.
    /// </summary>
    /// <param name="blobDataDestination">Blob data output for SetVarSubStreamed</param>
    /// <param name="challenge">Challenge from GetVarSubStreamed</param>
    /// <param name="publicKey">Public key required by PLC</param>
    /// <param name="sessionKey">Session key generated in the earlier authentication stage</param>
    /// <param name="password">The password</param>
    /// <exception cref="ArgumentException"></exception>
    public static void SolveLegitimateChallengePlcSim(
        Span<byte> blobDataDestination,
        ReadOnlySpan<byte> challenge,
        ReadOnlySpan<byte> publicKey,
        ReadOnlySpan<byte> sessionKey,
        string password)
    {
        var length = Encoding.UTF8.GetByteCount(password);
        Span<byte> passBytes = stackalloc byte[length];
        Encoding.UTF8.GetBytes(password, passBytes);
        
        Span<byte> hash = stackalloc byte[SHA1.HashSizeInBytes];
        _ = SHA1.HashData(passBytes, hash);
        
        SolveLegitimateChallengePlcSim(
            blobDataDestination, 
            challenge, 
            publicKey,
            sessionKey, 
            hash);
    }
    
    /// <summary>
    /// Solve the legitimation challenge to be able to communicate with PLCs that require a password.
    /// </summary>
    /// <param name="blobDataDestination">Blob data output for SetVarSubStreamed</param>
    /// <param name="challenge">Challenge from GetVarSubStreamed</param>
    /// <param name="publicKey">Public key required by PLC</param>
    /// <param name="sessionKey">Session key generated in the earlier authentication stage</param>
    /// <param name="passwordHash">SHA-1 hash of the PLC password</param>
    /// <exception cref="ArgumentException"></exception>
    public static void SolveLegitimateChallengePlcSim(
        Span<byte> blobDataDestination, 
        ReadOnlySpan<byte> challenge, 
        ReadOnlySpan<byte> publicKey,
        ReadOnlySpan<byte> sessionKey,
        ReadOnlySpan<byte> passwordHash)
    {
        if (blobDataDestination.Length < OutputBlobDataLengthPlcSim)
        {
            throw new ArgumentException($"BlobDataDestination must be at least {OutputBlobDataLengthPlcSim} bytes long",
                nameof(blobDataDestination));
        }

        if (passwordHash.Length < SHA1.HashSizeInBytes)
        {
            throw new ArgumentException("Password hash is not a SHA1 (too short)", nameof(passwordHash));
        }

        if (challenge.Length < ChallengeLength)
        {
            throw new ArgumentException($"Challenge must be at least {ChallengeLength} bytes long",
                nameof(challenge));
        }

        blobDataDestination.Clear();
        
        Span<byte> symmetricKey = stackalloc byte[Constants.SymmetricKeyLength];
        KeyUtilities.DeriveLegitimationChallengeKey(symmetricKey, sessionKey);
        
        Span<byte> challengeKey = stackalloc byte[CommonConstants.AesKeyLengthInBytes];
        KeyUtilities.DeriveChallengeEncryptionKey(challengeKey, symmetricKey);

        // The first metadata is at the beginning
        BlobMetadataWriter.WriteSeedBeefMetadata(
            blobDataDestination, 
            publicKey, 
            EPublicKeyFamily.PlcSim,
            symmetricKey
        );
        
        const int seedOffset = BlobMetadataWriter.BeefSeedMetadataLength;
        HarpoSeedUtilities.GenerateEncryptedSeed(
            blobDataDestination[seedOffset..], 
            publicKey, 
            challengeKey);
        
        // IV + Challenge
        const int ivChallengeMetadataOffset = 0xA0;
        WriteFragmentBeefMetadata(blobDataDestination[ivChallengeMetadataOffset..], 0, 0x40);

        Span<byte> iv = stackalloc byte[CommonConstants.AesIvLength];
        iv.FillWithCryptoRandomBytes();

        // Copy the IV
        const int ivOffset = 0xAC;
        iv.CopyTo(blobDataDestination[ivOffset..]);

        // Init AES-CTR
        using var aesCtr = new HarpoAesCtr(challengeKey[..CommonConstants.AesKeyLengthInBytes]);
        aesCtr.Init(iv);
        
        // Encrypt 16 0x00 bytes
        const int zeroCiphertextOffset = ivOffset + 0x10;
        {
            Span<byte> zeroBytes = stackalloc byte[16];
            aesCtr.EncryptCtr(zeroBytes, blobDataDestination[zeroCiphertextOffset..]);
        }

        // Encrypt hash+challenge
        const int encryptedHashOffset = zeroCiphertextOffset + 0x10;
        {
            const int hashPartLength = 0x14;
            const int challengePartLength = CommonConstants.AesBlockSize - hashPartLength;
            
            Span<byte> concat = stackalloc byte[hashPartLength + challengePartLength];
            passwordHash[..hashPartLength].CopyTo(concat);
            challenge[..challengePartLength].CopyTo(concat.Slice(hashPartLength, challengePartLength));
            
            aesCtr.EncryptCtr(concat, blobDataDestination[encryptedHashOffset..]);
        }

        // Challenge_part + AES-CTR-checksum
        const int checksumMetadataOffset = encryptedHashOffset + CommonConstants.AesBlockSize;
        WriteFragmentBeefMetadata(blobDataDestination[checksumMetadataOffset..], 1, 0x18);

        // Encrypt challenge_part (last 8 bytes of challenge)
        const int challengePartOffset = checksumMetadataOffset + 0x0C; 
        aesCtr.EncryptCtr(challenge[^8..], blobDataDestination[challengePartOffset..]);
        
        // Extract checksum
        const int checksumOffset = challengePartOffset + 8;
        aesCtr.CalculateChecksum(blobDataDestination.Slice(checksumOffset, 0x10));
        
        // Write last, empty beef fragment
        const int lastFragmentOffset = checksumOffset + 0x10;
        WriteFragmentBeefMetadata(blobDataDestination[lastFragmentOffset..], 2, 0);
    }

    internal static void WriteFragmentBeefMetadata(Span<byte> destination, int index, int length)
    {
        if (index < 0)
        {
            throw new ArgumentException("Index must be a positive number", nameof(index));
        }
        
        if (length < 0)
        {
            throw new ArgumentException("Length must be a positive number", nameof(length));
        }

        if (destination.Length < BeefFragmentMetadataLength)
        {
            throw new ArgumentException($"Destination must be larger than {BeefFragmentMetadataLength} bytes", 
                nameof(destination));
        }
        
        var dwords = destination.AsDwords();
        dwords[0] = DeadBeefMagic;
        dwords[1] = (uint)index;
        dwords[2] = (uint)length;
    }
}