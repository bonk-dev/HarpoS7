using HarpoS7.Keys;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Auth;

internal static class BlobMetadataWriter
{
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
        const uint blobMagic = 0xFEE1DEAD;
        
        // These are hardcoded to 1
        const uint unknownField1 = 1;
        const uint unknownField2 = 1;

        var blobDword = blobData.AsDwords();
        blobDword[0] = blobMagic;
        blobDword[1] = (uint)GetBlobLength(keyFamily);
        blobDword[2] = unknownField1;
        blobDword[3] = unknownField2;

        key1.DeriveKeyId(blobData[(sizeof(uint) * 4)..]);
        blobDword[6] = (uint)GetSymmetricKeyFlags(keyFamily);
        blobDword[7] = 0;

        publicKey.DeriveKeyId(blobData[(sizeof(uint) * 8)..]);
        blobDword[10] = (uint)GetPublicKeyFlags(keyFamily);
        blobDword[11] = 0;

        return 12 * sizeof(uint);
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
            EPublicKeyFamily.Family0 => CommonConstants.EncryptedBlobLengthFamilyZero,
            EPublicKeyFamily.Family3 => CommonConstants.EncryptedBlobLengthFamilyThree,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };
    
    /// <summary>
    /// Get the symmetric key flags based on the public key family sent by the PLC
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>Symmetric key flags</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetSymmetricKeyFlags(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.Family0 => 0x1,
            EPublicKeyFamily.Family3 => 0x301,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };
    
    /// <summary>
    /// Get the public key flags based on the public key family sent by the PLC
    /// </summary>
    /// <param name="keyFamily">The public key family</param>
    /// <returns>Public key flags</returns>
    /// <exception cref="ArgumentException">Thrown when the key family is invalid</exception>
    public static int GetPublicKeyFlags(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.Family0 => 0x10,
            EPublicKeyFamily.Family3 => 0x310,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };
}