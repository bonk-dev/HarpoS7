using System.Text.RegularExpressions;

namespace HarpoS7.Monoliths.Tests.Utils;

public static partial class BlobUtils
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
        Path.Combine(GetBasePath(), BlobsDirName, TransformsBlobsDirName, 
            $"transform{transformIndex}-src.bin");
    
    public static string GetTransformDestinationPath(int transformIndex) => 
        Path.Combine(GetBasePath(), BlobsDirName, TransformsBlobsDirName, 
            $"transform{transformIndex}-dst.bin");

    private static string GetBasePath() => TestContext.CurrentContext.WorkDirectory;
}