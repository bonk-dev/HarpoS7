using System.Runtime.InteropServices;
using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.BitOperations;

public static class BitOperation2
{
    public const int DestinationSize = 0x06 * sizeof(uint);
    public const int SourceSize = 0x05 * sizeof(uint);
    
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        if (destination.Length < DestinationSize)
        {
            throw new BufferLengthException(
                nameof(destination), false, DestinationSize, destination.Length);
        }
        if (source.Length < SourceSize)
        {
            throw new BufferLengthException(
                nameof(source), true, SourceSize, source.Length);
        }

        var dstDwords = MemoryMarshal.Cast<byte, uint>(destination);
        var srcDwords = MemoryMarshal.Cast<byte, uint>(source);
        
        dstDwords[0] = (srcDwords[0] & 0x0FFFFFFF) << 2;
        dstDwords[1] = (srcDwords[1] << 0x06 | srcDwords[0] >> 0x1A) & 0x3FFFFFFC;
        dstDwords[2] = (srcDwords[2] << 0x0A | srcDwords[1] >> 0x16) & 0x3FFFFFFC;
        dstDwords[3] = (srcDwords[2] >> 0x12 | srcDwords[3] << 0x0E) & 0x3FFFFFFC;
        dstDwords[4] = (srcDwords[4] << 0x12 | srcDwords[3] >> 0x0E) & 0x3FFFFFFC;
        dstDwords[5] = srcDwords[4] >> 0x0A & 0x3FFFFC;
    }
}