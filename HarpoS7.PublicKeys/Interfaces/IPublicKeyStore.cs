using HarpoS7.PublicKeys.Exceptions;

namespace HarpoS7.PublicKeys.Interfaces;

public interface IPublicKeyStore
{
    /// <summary>
    /// Gets the public key length based on the public key family
    /// </summary>
    /// <param name="variableNameFingerprint">The ObjectVariableTypeName value from the CreateObject response</param>
    /// <returns>Public key length in bytes</returns>
    int GetPublicKeyLength(string variableNameFingerprint);
    
    /// <summary>
    /// Writes a public key based on the fingerprint to the <see cref="destination"/>
    /// </summary>
    /// <param name="destination">The public key bytes destination</param>
    /// <param name="variableNameFingerprint">The ObjectVariableTypeName value from the CreateObject response</param>
    /// <exception cref="UnknownPublicKeyException">Thrown when the store does not contain a valid public key for the specified fingerprint</exception>
    void ReadPublicKey(Span<byte> destination, string variableNameFingerprint);
}