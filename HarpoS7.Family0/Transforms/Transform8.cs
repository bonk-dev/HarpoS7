using System.Numerics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.Transforms;

/// <summary>
/// Big integer transform - addition
/// </summary>
public static class Transform8
{
    public const int DestinationSize = BigIntOperations.FinalizeDestinationSize;
    public const int Source1Size = BigIntOperations.PrepareSourceSize;
    public const int Source2Size = BigIntOperations.PrepareSourceSize;
    
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
        
        Span<byte> buffer1 = stackalloc byte[BigIntOperations.PrepareDestinationSize];
        Span<byte> buffer2 = stackalloc byte[BigIntOperations.PrepareDestinationSize];
        BigIntOperations.Prepare(buffer1, source1);
        BigIntOperations.Prepare(buffer2, source2);

        var bigInt1 = new BigInteger(buffer1, isUnsigned: true, isBigEndian: false);
        var bigInt2 = new BigInteger(buffer2, isUnsigned: true, isBigEndian: false);
        var sum = bigInt1 + bigInt2;

        // TryWriteBytes(out int) and GetByteCount() can differ 
        var length = sum.GetByteCount();
        
        Span<byte> sumBuffer = stackalloc byte[length];
        _ = sum.TryWriteBytes(sumBuffer, out length, isUnsigned: true, isBigEndian: false);

        if (length > BigIntOperations.FinalizeSourceSize)
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
        
        BigIntOperations.Finalize(destination, sumBuffer);
    }
}