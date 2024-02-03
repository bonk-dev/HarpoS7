using HarpoS7.Keys;
// ReSharper disable UseCollectionExpression

namespace HarpoS7.PoC;

/// <summary>
/// Contains public keys and their corresponding key ids
/// </summary>
public static class PublicKeyStore
{
    private static readonly Dictionary<string, byte[]> PublicKeys = new();

    static PublicKeyStore() => AddPublicKey(PredefinedKeys.PlcSim1200PublicKey);

    public static byte[]? GetPublicKey(ReadOnlySpan<byte> keyFingerprint) =>
        PublicKeys.GetValueOrDefault(Convert.ToBase64String(keyFingerprint));
    
    // ReSharper disable once MemberCanBePrivate.Global
    public static void AddPublicKey(ReadOnlySpan<byte> publicKey) 
    {
        Span<byte> keyId = stackalloc byte[8];
        publicKey.DeriveKeyId(keyId);
        PublicKeys.Add(Convert.ToBase64String(keyId), publicKey.ToArray());
    }

    private static class PredefinedKeys
    {
        /// <summary>
        /// Key used by the simulated S7-1200 PLCs (PLCSIM V16).
        /// </summary>
        public static byte[] PlcSim1200PublicKey { get; } = new byte[64]
        {
            0xEC, 0xA6, 0xD7, 0x99, 0xDD, 0xF0, 0x3E, 0xAA, 0xDD, 0x16, 0xB5, 0xD7,
            0x24, 0x53, 0x31, 0xE4, 0x26, 0xC9, 0xE6, 0xBA, 0x89, 0x97, 0x87, 0x7A,
            0x73, 0x94, 0xF3, 0x28, 0x65, 0x32, 0xA6, 0xB0, 0x53, 0xE4, 0x22, 0x98,
            0x18, 0x08, 0x52, 0x23, 0x43, 0x24, 0x83, 0xFB, 0xA4, 0xD5, 0xC4, 0x3B,
            0xD6, 0xC3, 0x54, 0xC1, 0x0F, 0xEB, 0xC9, 0x03, 0x90, 0x8E, 0xD2, 0x71,
            0x69, 0x7F, 0x39, 0xE9
        };
    }
}