using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Utilities.Auth;

public static class BlobMetadataWriter
{
    public const int BeefSeedMetadataLength = 0x40;
    
    /// <summary>
    /// Writes encrypted blob metadata
    /// </summary>
    /// <param name="blobData">The output</param>
    /// <param name="publicKey">The used public key</param>
    /// <param name="key1">The key used for deriving session key</param>
    /// <param name="keyFamily">The public key family (see <see cref="EPublicKeyFamily"/> for explanation)</param>
    /// <returns>Next writeable offset in <paramref name="blobData"/></returns>
    public static int WriteMetadata(
        Span<byte> blobData,
        ReadOnlySpan<byte> publicKey,
        ReadOnlySpan<byte> key1,
        EPublicKeyFamily keyFamily)
    {
        var publicKeyLength = keyFamily switch
        {
            EPublicKeyFamily.S71500 => CommonConstants.PublicKeyLengthRealPlc,
            EPublicKeyFamily.S71200 => CommonConstants.PublicKeyLengthRealPlc,
            EPublicKeyFamily.PlcSim => CommonConstants.PublicKeyLengthPlcSim,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };

        if (publicKey.Length < publicKeyLength)
        {
            throw new ArgumentException(
                $"The public key ({publicKey.Length} bytes) is shorter than expected ({publicKeyLength} bytes)",
                nameof(publicKey)
            );
        }
        
        const uint blobMagic = 0xFEE1DEAD;
        const uint securityKeyVersion = 1;
        const uint securityLevelLegacyCsi = 1;

        var blobDword = blobData.AsDwords();
        blobDword[0] = blobMagic;
        blobDword[1] = (uint)GetBlobLength(keyFamily);
        blobDword[2] = securityKeyVersion;
        blobDword[3] = securityLevelLegacyCsi;

        const int symmetricKeyIdOffset = 4 * sizeof(uint);
        key1.DeriveKeyId(blobData[symmetricKeyIdOffset..]);
        blobDword[6] = (uint)GetSymmetricKeyFlags(keyFamily);
        blobDword[7] = 0;

        const int publicKeyIdOffset = 8 * sizeof(uint);
        publicKey.DeriveKeyId(blobData[publicKeyIdOffset..]);
        blobDword[10] = (uint)GetPublicKeyFlags(keyFamily);
        blobDword[11] = 0;

        return 12 * sizeof(uint);
    }
    
    public static void WriteSeedBeefMetadata(
        Span<byte> destination, 
        ReadOnlySpan<byte> publicKey,
        EPublicKeyFamily keyFamily,
        ReadOnlySpan<byte> symmetricKey)
    {
        var dwords = destination.AsDwords();

        const uint blobMagic = 0xDEADBEEFU;
        dwords[0] = blobMagic;
        dwords[1] = (uint)GetLegitimationSeedFragmentLength(keyFamily);
        dwords[2] = 0x01; // Maybe a version field;
        dwords[3] = 0x02; // Maybe SecurityTypeCSI; 2 is the Siemens legacy CSI mode.
        destination[0x15] = 0x04; // Maybe flags 0x400
        
        // public key
        publicKey.DeriveKeyId(destination[0x1C..]);
        dwords[9] = (uint)GetPublicKeyFlags(keyFamily); // public key flags
        dwords[10] = 0; // public key internal flags
        
        // symmetric key
        symmetricKey.DeriveKeyId(destination[0x2C..]);
        dwords[13] = (uint)GetSymmetricKeyFlagsLegitimation(keyFamily); // symmetric key flags
        dwords[14] = 0; // symmetric key internal flags

        dwords[15] = (uint)GetEncryptedSeedLength(keyFamily);
    }

    /// <summary>
    /// Get the blob data length based on the public key family sent by the PLC
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>The blob data length</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetBlobLength(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.S71500 => CommonConstants.EncryptedBlobLengthRealPlc,
            EPublicKeyFamily.S71200 => CommonConstants.EncryptedBlobLengthRealPlc,
            EPublicKeyFamily.PlcSim => CommonConstants.EncryptedBlobLengthPlcSim,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };
    
    /// <summary>
    /// Get the legitimation seed fragment data length based on the public key family sent by the PLC
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>The legitimation seed fragment data length</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetLegitimationSeedFragmentLength(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.S71500 => BeefSeedMetadataLength + CommonConstants.EncryptedSeedLengthRealPlc,
            EPublicKeyFamily.S71200 => BeefSeedMetadataLength + CommonConstants.EncryptedSeedLengthRealPlc,
            EPublicKeyFamily.PlcSim => BeefSeedMetadataLength + CommonConstants.EncryptedSeedLength,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };
    
    /// <summary>
    /// Get the Siemens CSI symmetric-session-key flags based on the public-key family sent by the PLC.
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>Symmetric key flags</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetSymmetricKeyFlags(EPublicKeyFamily keyFamily) =>
        SiemensCsiKeyFlags.GetSymmetricKeyFlags(keyFamily);
    
    /// <summary>
    /// Get the Siemens CSI symmetric-session-key flags used by the legitimation process.
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>Symmetric key flags</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetSymmetricKeyFlagsLegitimation(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.S71500 => 0x1,
            EPublicKeyFamily.S71200 => 0x1,
            EPublicKeyFamily.PlcSim => SiemensCsiKeyFlags.GetSymmetricKeyFlags(keyFamily),
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };
    
    /// <summary>
    /// Get the Siemens CSI communication public-key flags based on the public-key family sent by the PLC.
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>Public key flags</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetPublicKeyFlags(EPublicKeyFamily keyFamily) =>
        SiemensCsiKeyFlags.GetCommPublicKeyFlags(keyFamily);

    /// <summary>
    /// Get the encrypted seed length based on the public key family sent by the PLC
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>The encrypted seed length</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetEncryptedSeedLength(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.S71500 => CommonConstants.EncryptedSeedLengthRealPlc,
            EPublicKeyFamily.S71200 => CommonConstants.EncryptedSeedLengthRealPlc,
            EPublicKeyFamily.PlcSim => CommonConstants.EncryptedSeedLength,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };
}