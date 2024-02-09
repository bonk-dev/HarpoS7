using System.Collections.Concurrent;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using CommandLine;
using HarpoS7.KeyDumper;
using HarpoS7.KeyDumper.Cli;
using HarpoS7.KeyDumper.Models;

var optionsResult = Parser.Default.ParseArguments<Options>(args);
var options = optionsResult.Value;

var logger = new Logger(options.Quiet);
var doSingleMpk = !string.IsNullOrEmpty(options.MpkFilePath);
var doSpecificDir = !string.IsNullOrEmpty(options.TiaPortalDirectory);

if (doSingleMpk && doSpecificDir)
{
    logger.LogError("You cannot use both the MPK file path option and the TIA Portal option at the same time");
    Environment.Exit((int)EExitCodes.BothTiaPortalDirAndMpkDefined);
}

List<string> mpkFiles = new();
if (doSpecificDir)
{
    logger.LogInfo($"Looking for key MPK files in {options.TiaPortalDirectory}");
    
    var (result, files) = FileFinder.FindKeyMpkFilesInInstallDir(options.TiaPortalDirectory);
    switch (result)
    {
        case FileFinder.EFindResult.KeysDirNotExist:
            logger.LogError("The specified TIA Portal directory exists, but Data/Hwcn/Custom/Keys directory was not found");
            Environment.Exit((int)EExitCodes.KeysDirNotFound);
            break;
        case FileFinder.EFindResult.TiaPortalNotExist:
            logger.LogError("The specified TIA Portal directory does not exist");
            Environment.Exit((int)EExitCodes.OptionTiaPortalDirNotFound);
            break;
    }
    
    mpkFiles.AddRange(files);
}
else if (doSingleMpk)
{
    logger.LogInfo($"Extracting keys from a single MPK file: {options.MpkFilePath}");
    
    if (!File.Exists(options.MpkFilePath))
    {
        logger.LogError("The specified MPK file does not exist");
        Environment.Exit((int)EExitCodes.MpkFileNotFound);
    }
    
    mpkFiles.Add(options.MpkFilePath);
}
else
{
    logger.LogInfo("No TIA Portal dir specified nor MPK file");
    logger.LogInfo("Looking for TIA Portal install dir");

    var tiaDir = FileFinder.FindTiaPortalInstallDir();
    if (string.IsNullOrEmpty(tiaDir))
    {
        logger.LogError("Could not find a valid TIA Portal install dir");
        logger.LogError("Specify the install dir (eg. Portal V16) with the -t option");
        Environment.Exit((int)EExitCodes.AutoTiaPortalDirNotFound);
    }
    
    logger.LogInfo($"Found the TIA Portal install dir: {tiaDir}");
    logger.LogInfo($"Looking for key MPK files in {tiaDir}");
    
    var (result, files) = FileFinder.FindKeyMpkFilesInInstallDir(tiaDir);
    switch (result)
    {
        case FileFinder.EFindResult.KeysDirNotExist:
            logger.LogError("The specified TIA Portal directory exists, but Data/Hwcn/Custom/Keys directory was not found");
            Environment.Exit((int)EExitCodes.KeysDirNotFound);
            break;
        case FileFinder.EFindResult.TiaPortalNotExist:
            logger.LogError("The specified TIA Portal directory does not exist");
            Environment.Exit((int)EExitCodes.OptionTiaPortalDirNotFound);
            break;
    }
    
    mpkFiles.AddRange(files);
}

var index = 0;
ConcurrentBag<KeyData> keyDataCollection = [];

await Parallel.ForEachAsync(mpkFiles, async (mpkFile, token) =>
{
    var taskIndex = ++index;
    logger.LogInfo($"Reading keys from {mpkFile} (#{taskIndex})");
    
    await using var stream = new FileStream(mpkFile, FileMode.Open, FileAccess.Read, FileShare.Read);
    await using var reader = new KeyReader(stream);

    await foreach (var key in reader.EnumerateKeysFromMpkAsync())
    {
        logger.LogInfo($"(#{taskIndex}) Key read: {key.OrderNumber}");
        keyDataCollection.Add(key);
    }
});

logger.LogInfo("All keys dumped from the files");

var output = string.IsNullOrEmpty(options.OutputFilePath) 
    ? Path.Combine(Directory.GetCurrentDirectory(), "key-dump.json") 
    : options.OutputFilePath;
logger.LogInfo($"Saving to {output}");

var dir = Path.GetDirectoryName(output);
if (!string.IsNullOrEmpty(dir))
{
    Directory.CreateDirectory(dir);   
}

await using var stream =
    new FileStream(output, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
stream.SetLength(0L);

var jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.General)
{
    WriteIndented = options.IndentJson,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
};
await JsonSerializer.SerializeAsync(
    stream, 
    keyDataCollection.AsEnumerable(), 
    jsonOptions);

logger.LogInfo("All done!");

if (!options.DoNotWaitForKey)
{
    logger.LogInfo("Press any key to exit");
    Console.ReadKey(true);
}