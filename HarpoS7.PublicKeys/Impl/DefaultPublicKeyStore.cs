using System.Reflection;
using HarpoS7.PublicKeys.Exceptions;
using HarpoS7.PublicKeys.Interfaces;

namespace HarpoS7.PublicKeys.Impl;

public class DefaultPublicKeyStore : IPublicKeyStore
{
    /// <inheritdoc/>
    public int GetPublicKeyLength(string variableNameFingerprint) =>
        GetFamilyType(variableNameFingerprint) switch
        {
            "00" => Constants.PublicKeyLengthRealPlc,
            "01" => Constants.PublicKeyLengthRealPlc,
            "03" => Constants.PublicKeyLengthPlcSim,
            _ => throw new ArgumentException($"Unsupported public key family ({GetFamilyType(variableNameFingerprint)})")
        };

    /// <inheritdoc/>
    public void ReadPublicKey(Span<byte> destination, string variableNameFingerprint)
    {
        const string baseNameSpace = "HarpoS7.PublicKeys.Keys";
        const string extension = ".bin";
        
        // Namespace parts which begin with a number must start with a '_'
        var resourceName = $"{baseNameSpace}._{GetFamilyType(variableNameFingerprint)}.{GetKeyId(variableNameFingerprint)}{extension}";
        
        using var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            throw new UnknownPublicKeyException(variableNameFingerprint);
        }
        
        _ = stream.Read(destination);
    }

    internal static string GetFamilyType(string variableNameFingerprint) => 
        variableNameFingerprint[..2];
    
    internal static string GetKeyId(string variableNameFingerprint) => 
        variableNameFingerprint[3..];
}