namespace HarpoS7.Monoliths.Tests.Utils;

public static class BlobUtils
{
    private const string BlobsDirName = "Blobs";
    
    public static string GetSourcePath(int index) => 
        Path.Combine(GetBasePath(), BlobsDirName, $"monolith{index}-src.bin");
    
    public static string GetDestinationPath(int index) => 
        Path.Combine(GetBasePath(), BlobsDirName, $"monolith{index}-dst.bin");

    private static string GetBasePath() => TestContext.CurrentContext.WorkDirectory;
}