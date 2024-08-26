namespace HarpoS7.PublicKeys.Exceptions;

public class UnknownPublicKeyException : Exception
{
    public override string Message { get; }

    public UnknownPublicKeyException(string fingerprint)
    {
        Message = $"The key store does not contain a public key for the \"{fingerprint}\" fingerprint";
    }
}