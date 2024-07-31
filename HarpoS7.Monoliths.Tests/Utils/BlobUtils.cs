namespace HarpoS7.Monoliths.Tests.Utils;

public static class BlobUtils
{
    private const string BitOperationsBlobsDirName = "BitOperations";
    private const string BlobsDirName = "Blobs";
    private const string MonolithsBlobsDirName = "Monoliths";
    private const string MonolithsWithCopyBlobsDirName = "WithCopy";
    private const string TransformsBlobsDirName = "Transforms";
    
    public static string GetSourcePath(int index) => 
        Path.Combine(GetBasePath(), BlobsDirName, MonolithsBlobsDirName, 
            $"monolith{index}-src.bin");
    
    public static string GetDestinationPath(int index) => 
        Path.Combine(GetBasePath(), BlobsDirName, MonolithsBlobsDirName, 
            $"monolith{index}-dst.bin");

    public static string GetTransformSourcePath(int transformIndex, int? subIndex = null) => 
        GetTransformFilePath(transformIndex, "src", subIndex);

    public static string GetTransformDestinationPath(int transformIndex, int? subIndex = null) =>
        GetTransformFilePath(transformIndex, "dst", subIndex);

    public static string GetTransformFilePath(int transformIndex, string postfix, int? subIndex = null)
    {
        var subIndexPart = subIndex == null
            ? string.Empty
            : '_' + subIndex.ToString();
        return Path.Combine(GetBasePath(), BlobsDirName, TransformsBlobsDirName,
            $"transform{transformIndex}{subIndexPart}-{postfix}.bin");
    }

    public static string GetWithCopyBlobPath(int monolithIndex, bool isOut, int index) =>
        Path.Combine(GetBasePath(), BlobsDirName, MonolithsWithCopyBlobsDirName, 
            $"{monolithIndex}_{(isOut ? "out" : "in")}{index}.bin");

    public static string GetBitOperationBlobPath(string name, bool isDst) =>
        Path.Combine(GetBasePath(), BlobsDirName, BitOperationsBlobsDirName,
            $"{name}_{(isDst ? "dst" : "src")}.bin");

    private static string GetBasePath() => TestContext.CurrentContext.WorkDirectory;
}