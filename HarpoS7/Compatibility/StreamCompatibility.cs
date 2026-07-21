using System.Runtime.InteropServices;

namespace HarpoS7.Compatibility;

internal static class StreamCompatibility
{
    public static async Task<int> ReadAsync(Stream stream, Memory<byte> buffer, CancellationToken cancellationToken)
    {
#if NETSTANDARD2_0
        if (MemoryMarshal.TryGetArray((ReadOnlyMemory<byte>)buffer, out var segment))
        {
            return await stream.ReadAsync(segment.Array!, segment.Offset, segment.Count, cancellationToken);
        }

        var temporaryBuffer = new byte[buffer.Length];
        var bytesRead = await stream.ReadAsync(temporaryBuffer, 0, temporaryBuffer.Length, cancellationToken);
        temporaryBuffer.AsSpan(0, bytesRead).CopyTo(buffer.Span);
        return bytesRead;
#else
        return await stream.ReadAsync(buffer, cancellationToken);
#endif
    }

    public static async Task WriteAsync(Stream stream, ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
    {
#if NETSTANDARD2_0
        if (MemoryMarshal.TryGetArray(buffer, out var segment))
        {
            await stream.WriteAsync(segment.Array!, segment.Offset, segment.Count, cancellationToken);
            return;
        }

        var temporaryBuffer = buffer.ToArray();
        await stream.WriteAsync(temporaryBuffer, 0, temporaryBuffer.Length, cancellationToken);
#else
        await stream.WriteAsync(buffer, cancellationToken);
#endif
    }
}
