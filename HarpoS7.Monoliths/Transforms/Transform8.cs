using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Exceptions;
using HarpoS7.Utilities;

namespace HarpoS7.Monoliths.Transforms;

public static class Transform8
{
    public const int DestinationSize = BitOperation2.DestinationSize;
    public const int Source1Size = BitOperation1.SourceSize;
    public const int Source2Size = BitOperation1.SourceSize;
    
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source1, ReadOnlySpan<byte> source2)
    {
        if (destination.Length < DestinationSize)
        {
            throw new BufferLengthException(
                nameof(destination), false, DestinationSize, destination.Length);
        }
        if (source1.Length < Source1Size)
        {
            throw new BufferLengthException(
                nameof(source1), true, Source1Size, source1.Length);
        }
        if (source2.Length < Source2Size)
        {
            throw new BufferLengthException(
                nameof(source2), true, Source2Size, source2.Length);
        }
        
        Span<byte> buffer1 = stackalloc byte[BitOperation1.DestinationSize];
        Span<byte> buffer2 = stackalloc byte[BitOperation1.DestinationSize];
        BitOperation1.Execute(buffer1, source1);
        BitOperation1.Execute(buffer2, source2);

        var bigInt1 = new BigInteger(buffer1, isUnsigned: true, isBigEndian: false);
        var bigInt2 = new BigInteger(buffer2, isUnsigned: true, isBigEndian: false);
        var sum = bigInt1 + bigInt2;

        // TryWriteBytes(out int) and GetByteCount() can differ 
        var length = sum.GetByteCount();
        
        Span<byte> sumBuffer = stackalloc byte[length];
        _ = sum.TryWriteBytes(sumBuffer, out length, isUnsigned: true, isBigEndian: false);

        if (length > BitOperation2.SourceSize)
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