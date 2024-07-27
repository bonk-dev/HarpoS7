using System.Reflection;

namespace HarpoS7.Monoliths.Data;

public static class BlobReader
{
    private static Memory<byte> _t12Metadata = Memory<byte>.Empty;

    public static ReadOnlyMemory<byte> Transform12Metadata
    {
        get
        {
            if (_t12Metadata.IsEmpty)
            {
                ReadTransform12Metadata();
            }

            return _t12Metadata;
        }
    }
    
    public static void ReadTransform12Metadata()
    {
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("HarpoS7.Monoliths.Data.Blobs.Transform12Metadata.bin");
        if (stream == null)
        {
            throw new Exception("Transform12 metadata stream was null");
        }
        
        _t12Metadata = new byte[stream.Length];
        _ = stream.Read(_t12Metadata.Span);
    }
}