using System.Runtime.InteropServices;
using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.BitOperations;

public static class BitOperation1
{
    public const int DestinationSize = 0x05 * sizeof(uint);
    public const int SourceSize = 0x04 * sizeof(uint);
    
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

        var temp0 = srcDwords[0];
        var temp1 = (srcDwords[1] << 0x1A) + (temp0 >> 2);
        dstDwords[0] = temp1;
        
        temp1 = (CarryHelper(temp1, temp0) >> 2) + (srcDwords[1] >> 6);
        temp0 = srcDwords[2] * 0x400000 + temp1;
        dstDwords[1] = temp0;
        
        temp1 = CarryHelper(temp0, temp1) + (srcDwords[2] >> 10);
        temp0 = srcDwords[3] * 0x40000 + temp1;
        dstDwords[2] = temp0;
        
        temp1 = CarryHelper(temp0, temp1) + (srcDwords[3] >> 0xe);
        temp0 = srcDwords[4] * 0x4000 + temp1;
        dstDwords[3] = temp0;
        
        temp1 = CarryHelper(temp0, temp1) + (srcDwords[4] >> 0x12);
        temp0 = srcDwords[5] * 0x400 + temp1;
        dstDwords[4] = temp0;
        
        temp0 = (CarryHelper(temp0, temp1) + (srcDwords[5] >> 0x16)) * 0x2f;
        
        if (temp0 != 0) {
            dstDwords[0] += temp0;
            dstDwords[1] += CarryHelper(dstDwords[0], temp0);
            
            temp0 = CarryHelper(dstDwords[1], CarryHelper(dstDwords[0], temp0));
            dstDwords[2] += temp0;
            
            temp0 = CarryHelper(dstDwords[2], temp0);
            dstDwords[3] += temp0;
            
            temp0 = CarryHelper(dstDwords[3], temp0);
            dstDwords[4] += temp0;
            
            dstDwords[0] += CarryHelper(dstDwords[4], temp0) * 0x2f;
        }
    }

    private static uint CarryHelper(uint a, uint b) => 
        a < b ? 1U : 0U;
}