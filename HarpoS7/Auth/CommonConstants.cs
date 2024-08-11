namespace HarpoS7.Auth;

public static class CommonConstants
{
    public const int EncryptedBlobLengthRealPlc = 180;
    public const int EncryptedBlobLengthPlcSim = 216;

    public const int PublicKeyLengthRealPlc = 40;
    public const int PublicKeyLengthPlcSim = 64;
    
    public const int EncryptedSeedLength = 96;
    public const int AesKeyLengthInBytes = 128 / 8;
    public const int AesIvLength = 16;
    public const int AesBlockSize = 256 / 8;
}