namespace HarpoS7.Monoliths.Tests.Utils;

public static class BlobUtils
{
    private const string BlobsDirName = "Blobs";
    private const string MonolithsBlobsDirName = "Monoliths";
    private const string TransformsBlobsDirName = "Transforms";
    
    public static string GetSourcePath(int index) => 
        Path.Combine(GetBasePath(), BlobsDirName, MonolithsBlobsDirName, 
            $"monolith{index}-src.bin");
    
    public static string GetDestinationPath(int index) => 
        Path.Combine(GetBasePath(), BlobsDirName, MonolithsBlobsDirName, 
            $"monolith{index}-dst.bin");

    public static string GetTransformSourcePath(int transformIndex) => 
        GetTransformFilePath(transformIndex, "src");

    public static string GetTransformDestinationPath(int transformIndex) =>
        GetTransformFilePath(transformIndex, "dst");

    public static string GetTransformFilePath(int transformIndex, string postfix) => 
        Path.Combine(GetBasePath(), BlobsDirName, TransformsBlobsDirName, 
            $"transform{transformIndex}-{postfix}.bin");

    private static string GetBasePath() => TestContext.CurrentContext.WorkDirectory;
}