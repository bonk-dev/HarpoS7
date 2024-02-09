namespace HarpoS7.KeyDumper.Exceptions;

public class MalformedKeyFile : Exception
{
    public string Reason { get; }
    public override string Message => $"One of the key files is malformed (reason: ${Reason})";

    public MalformedKeyFile(string reason)
    {
        Reason = reason;
    }
}