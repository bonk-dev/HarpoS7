namespace HarpoS7.Utilities.Auth;

/// <summary>
/// Siemens OMS CSI key-id flag layout.
/// The low byte identifies the key type; bits 8..15 identify the public-key family.
/// </summary>
public static class SiemensCsiKeyFlags
{
    public const int KeyTypeSymmetricSessionKey = 0x01;
    public const int KeyTypeCpuPublicKey = 0x02;
    public const int KeyTypeFamilyPublicKey = 0x04;
    public const int KeyTypeCommPublicKey = 0x10;

    public const int KeyFamilyCpu1500 = 0x0000;
    public const int KeyFamilyCpu1200 = 0x0100;
    public const int KeyFamilyWinAc = 0x0200;
    public const int KeyFamilyVPlc = 0x0300;
    public const int KeyFamilyOpenSsl = 0x8000;
    public const int KeyFamilyPms = 0x8200;
    public const int KeyFamilyNoSecurity = 0xFF00;

    public static int GetFamilyFlags(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.S71500 => KeyFamilyCpu1500,
            EPublicKeyFamily.S71200 => KeyFamilyCpu1200,
            EPublicKeyFamily.PlcSim => KeyFamilyVPlc,
            _ => throw new ArgumentException("Invalid public key family", nameof(keyFamily))
        };

    public static int GetSymmetricKeyFlags(EPublicKeyFamily keyFamily) =>
        KeyTypeSymmetricSessionKey | GetFamilyFlags(keyFamily);

    public static int GetCommPublicKeyFlags(EPublicKeyFamily keyFamily) =>
        KeyTypeCommPublicKey | GetFamilyFlags(keyFamily);

    public static string GetSiemensFamilyName(EPublicKeyFamily keyFamily) =>
        keyFamily switch
        {
            EPublicKeyFamily.S71500 => "KeyFamilyCPU1500",
            EPublicKeyFamily.S71200 => "KeyFamilyCPU1200",
            EPublicKeyFamily.PlcSim => "KeyFamilyVPLC",
            _ => $"UnknownKeyFamily({(int)keyFamily})"
        };
}
