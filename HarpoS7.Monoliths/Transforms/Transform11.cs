using System.Numerics;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.Transforms;

/// <summary>
/// Big integer transform - subtraction
/// </summary>
public static class Transform11
{
    public const int DestinationSize = BigIntOperations.FinalizeDestinationSize;
    public const int MinuendSize = BigIntOperations.PrepareDestinationSize;
    public const int SubtrahendSize = BigIntOperations.PrepareSourceSize;
    
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> minuend, ReadOnlySpan<byte> subtrahend)
    {
        if (destination.Length < DestinationSize)
        {
            throw new BufferLengthException(
                nameof(destination), false, DestinationSize, destination.Length);
        }
        if (minuend.Length < MinuendSize)
        {
            throw new BufferLengthException(
                nameof(minuend), true, MinuendSize, minuend.Length);
        }
        if (subtrahend.Length < SubtrahendSize)
        {
            throw new BufferLengthException(
                nameof(subtrahend), true, SubtrahendSize, subtrahend.Length);
        }
        
        Span<byte> minuendBuffer = stackalloc byte[BigIntOperations.PrepareDestinationSize];
        BigIntOperations.Prepare(minuendBuffer, minuend);

        Span<byte> subtrahendBuffer = stackalloc byte[BigIntOperations.PrepareDestinationSize];
        BigIntOperations.Prepare(subtrahendBuffer, subtrahend);

        var minuendBigInt = new BigInteger(minuendBuffer, isUnsigned: true, isBigEndian: false);
        var subtrahendBigInt = new BigInteger(subtrahendBuffer, isUnsigned: true, isBigEndian: false);
        var difference = minuendBigInt - subtrahendBigInt;

        var diffLength = difference.GetByteCount();
        Span<byte> diffBytes = stackalloc byte[diffLength];
        _ = difference.TryWriteBytes(diffBytes, out diffLength, isUnsigned: true, isBigEndian: false);

        if (diffLength > BigIntOperations.FinalizeSourceSize)
        {
            throw new NotImplementedException($"Difference was larger than {BigIntOperations.FinalizeSourceSize}");
        }
        
        BigIntOperations.Finalize(destination, diffBytes[..diffLength]);
    }
}