using CommandLine;

namespace HarpoS7.KeyDumper.Cli;

public class Options
{
    [Option('t', "tia-portal", Required = false, HelpText = "Dump keys from this TIA Portal installation directory")]
    public string TiaPortalDirectory { get; set; } = string.Empty;

    [Option('m', "mpk-file", Required = false, HelpText = "Dump keys from this single MPK file")]
    public string MpkFilePath { get; set; } = string.Empty;
    
    [Option('q', "quiet", Required = false, HelpText = "Do not output anything to stdout")]
    public bool Quiet { get; set; }

    [Option('o', "output", Required = false, HelpText = "The output file path containing dumped keys. Put in 'stdout' to output the JSON result to the standard output")]
    public string OutputFilePath { get; set; } = string.Empty;
    
    [Option('j', "indent-json", Required = false, HelpText = "Whether or not to indent the resulting JSON", Default = true)]
    public bool IndentJson { get; set; }
    
    [Option('w', "do-not-wait", Required = false, HelpText = "Whether or not to wait for a key press on exit")]
    public bool DoNotWaitForKey { get; set; }
}