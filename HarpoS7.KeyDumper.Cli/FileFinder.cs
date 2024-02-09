namespace HarpoS7.KeyDumper.Cli;

public static class FileFinder
{
    public static (EFindResult, IEnumerable<string>) FindKeyMpkFilesInInstallDir(string tiaPortalDir)
    {
        if (!Directory.Exists(tiaPortalDir))
        {
            return (EFindResult.TiaPortalNotExist, ArraySegment<string>.Empty);
        }
        
        var path = Path.Combine(tiaPortalDir, "Data", "Hwcn", "Custom", "Keys");
        return !Directory.Exists(path) 
            ? (EFindResult.KeysDirNotExist, ArraySegment<string>.Empty) 
            : (EFindResult.Success, Directory.GetFiles(path, "*.mpk"));
    }

    public static string? FindTiaPortalInstallDir()
    {
        var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        var siemensAutomation = Path.Combine(programFiles, "Siemens", "Automation");
        return Directory.Exists(siemensAutomation) 
            ? Directory
                .EnumerateDirectories(siemensAutomation, "Portal V*")
                .FirstOrDefault() 
            : null;
    }
    
    public enum EFindResult
    {
        TiaPortalNotExist,
        KeysDirNotExist,
        Success
    }
}