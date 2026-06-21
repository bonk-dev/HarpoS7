using System.Reflection;
using HarpoS7.PublicKeys.Exceptions;
using HarpoS7.PublicKeys.Interfaces;

namespace HarpoS7.PublicKeys.Impl;

public class DefaultPublicKeyStore : IPublicKeyStore
{
    /// <inheritdoc/>
    public int GetPublicKeyLength(string variableNameFingerprint) =>
        GetFamilyPrefix(variableNameFingerprint) switch
        {
            "00" => Constants.PublicKeyLengthRealPlc,
            "01" => Constants.PublicKeyLengthRealPlc,
            "03" => Constants.PublicKeyLengthPlcSim,
            _ => throw new ArgumentException($"Unsupported Siemens OMS public-key family prefix '{GetFamilyPrefix(variableNameFingerprint)}'.")
        };

    /// <inheritdoc/>
    public void ReadPublicKey(Span<byte> destination, string variableNameFingerprint)
    {
        const string baseNameSpace = "HarpoS7.PublicKeys.Keys";
        const string extension = ".bin";
        
        // Namespace parts which begin with a number must start with a '_'
        var resourceName = $"{baseNameSpace}._{GetFamilyPrefix(variableNameFingerprint)}.{GetKeyId(variableNameFingerprint)}{extension}";
        
        using var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            throw new UnknownPublicKeyException(variableNameFingerprint);
        }
        
        _ = stream.Read(destination);
    }

    internal static string GetFamilyPrefix(string variableNameFingerprint)
    {
        if (string.IsNullOrWhiteSpace(variableNameFingerprint) || variableNameFingerprint.Length < 2)
        {
            throw new ArgumentException("Fingerprint must start with a two-digit Siemens OMS key-family prefix.", nameof(variableNameFingerprint));
        }

        return variableNameFingerprint[..2];
    }
    
    internal static string GetKeyId(string variableNameFingerprint) => 
        variableNameFingerprint[3..];
}
