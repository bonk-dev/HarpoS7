using System.Reflection;

namespace HarpoS7.Family0.Data;

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
        using var stream = assembly.GetManifestResourceStream("HarpoS7.Family0.Data.Blobs.Transform12Metadata.bin");
        if (stream == null)
        {
            throw new Exception("Transform12 metadata stream was null");
        }
        
        var metadata = new byte[stream.Length];
        var offset = 0;
        while (offset < metadata.Length)
        {
            var bytesRead = stream.Read(metadata, offset, metadata.Length - offset);
            if (bytesRead == 0)
            {
                throw new EndOfStreamException("Transform12 metadata stream ended unexpectedly");
            }

            offset += bytesRead;
        }

        _t12Metadata = metadata;
    }
}
