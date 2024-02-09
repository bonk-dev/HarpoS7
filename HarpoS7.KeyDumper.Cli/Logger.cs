namespace HarpoS7.KeyDumper.Cli;

public class Logger
{
    private readonly bool _quiet;

    public Logger(bool quiet = false)
    {
        _quiet = quiet;
    }

    public void LogInfo(string message) => Console.WriteLine(message);
    public void LogError(string message) => Console.WriteLine(message);
}