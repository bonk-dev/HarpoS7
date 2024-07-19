using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Utilities;

namespace HarpoS7.Monoliths.Transforms;

public static class Transform8
{
    public const int DestinationSize = BitOperation2.DestinationSize;
    public const int Source1Size = BitOperation1.SourceSize;
    public const int Source2Size = BitOperation1.SourceSize;
    
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source1, ReadOnlySpan<byte> source2)
    {
        Span<byte> buffer1 = stackalloc byte[BitOperation1.DestinationSize];
        Span<byte> buffer2 = stackalloc byte[BitOperation1.DestinationSize];
        BitOperation1.Execute(buffer1, source1);
        BitOperation1.Execute(buffer2, source2);

        Span<byte> sumBuffer = stackalloc byte[BitOperation1.DestinationSize];
        var overflow = BigIntegerBuffer.AddLowEndian(sumBuffer, buffer1, buffer2);

        // TODO: find out what this is
        if (overflow)
        {
            var sumDword = MemoryMarshal.Cast<byte, uint>(sumBuffer);
            sumDword[0] += 0x2F;

            var carry = sumDword[0] < 0x2F ? 1U : 0U;
            if (carry != 0)
            {
                for (var i = 1; i < 4; ++i)
                {
                    sumDword[i] += carry;
                    carry = sumDword[i] < carry ? 1U : 0U;
                }

                if (carry != 0)
                {
                    sumDword[0] += 0x5e;
                }
            }
        }
        
        BitOperation2.Execute(destination, sumBuffer);
    }
}