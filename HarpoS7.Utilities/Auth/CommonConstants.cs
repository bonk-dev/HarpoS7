namespace HarpoS7.Utilities.Auth;

public static class CommonConstants
{
    public const int EncryptedBlobLengthRealPlc = 180;
    public const int EncryptedBlobLengthPlcSim = 216;
 
    private const int BlobLengthOffset = 68;
    public const int EncryptedLegitimationBlobLengthRealPlc = EncryptedBlobLengthRealPlc + BlobLengthOffset;
    public const int EncryptedLegitimationBlobLengthPlcSim = EncryptedBlobLengthPlcSim + BlobLengthOffset;

    public const int PublicKeyLengthRealPlc = 40;
    public const int PublicKeyLengthPlcSim = 64;
    
    public const int EncryptedSeedLengthRealPlc = 96;
    public const int EncryptedSeedLength = 96;
    
    public const int AesKeyLengthInBytes = 128 / 8;
    public const int AesIvLength = 16;
    public const int AesBlockSize = 256 / 8;
}