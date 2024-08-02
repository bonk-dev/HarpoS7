using System.Runtime.InteropServices;
using HarpoS7.Monoliths.Exceptions;
using HarpoS7.Monoliths.Impl;
using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Transforms;

public static class Transform13
{
    private static readonly Memory<byte> StaticMask = new byte[0xC]
    {
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00  
    };
    
    public const int DestinationSize = 0x3C;
    public const int SourceSize = 0x3C;
    
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
        
        var staticMask = StaticMask.Span;
        
        Span<byte> monolith10Mask = stackalloc byte[staticMask.Length + SourceSize];
        staticMask.CopyTo(monolith10Mask);
        source[..SourceSize].CopyTo(monolith10Mask[staticMask.Length..]);

        // + 5 dwords is to match the Monolith9 source size
        Span<byte> monolith10Destination = stackalloc byte[MonolithBufferSizes.GetDestinationBufferSize(10) + 
                                                           5 * sizeof(uint)];
        Monolith10.Execute(monolith10Destination, monolith10Mask);

        Span<byte> monolith9Destination = stackalloc byte[MonolithBufferSizes.GetDestinationBufferSize(9)];
        for (var i = 6; i < 9; ++i)
        {
            var m10DstDwords = MemoryMarshal.Cast<byte, uint>(monolith10Destination);
            m10DstDwords[0xC0] = Data.SharedData.Data.Span[i * 2];
            m10DstDwords[0xC1] = Data.SharedData.Data.Span[i * 2 + 1];
            m10DstDwords[0xC2] = 0x4F5BB379;
            m10DstDwords[0xC3] = 0x90BA725F;
            m10DstDwords[0xC4] = 0x36A4D7BB;
            
            Monolith9.Execute(monolith9Destination, monolith10Destination);

            var destinationIndex = 0x18 * (i - 6);
            var copyLength = i < 8
                ? 0x18
                : 0xC;
            
            monolith9Destination[..copyLength].CopyTo(destination[destinationIndex..]);

            if (i == 7)
            {
                monolith10Mask[..staticMask.Length].Clear();
                Monolith10.Execute(monolith10Destination, monolith10Mask);
            }
        }
    }
}