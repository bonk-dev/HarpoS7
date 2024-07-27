using System.Numerics;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.Transforms;

/// <summary>
/// Big integer transform - subtraction
/// </summary>
public static class Transform11
{
    public const int DestinationSize = BitOperation2.DestinationSize;
    public const int MinuendSize = BitOperation1.SourceSize;
    public const int SubtrahendSize = BitOperation1.SourceSize;
    
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
        
        Span<byte> minuendBuffer = stackalloc byte[BitOperation1.DestinationSize];
        BitOperation1.Execute(minuendBuffer, minuend);

        Span<byte> subtrahendBuffer = stackalloc byte[BitOperation1.DestinationSize];
        BitOperation1.Execute(subtrahendBuffer, subtrahend);

        var minuendBigInt = new BigInteger(minuendBuffer, isUnsigned: true, isBigEndian: false);
        var subtrahendBigInt = new BigInteger(subtrahendBuffer, isUnsigned: true, isBigEndian: false);
        var difference = minuendBigInt - subtrahendBigInt;

        var diffLength = difference.GetByteCount();
        Span<byte> diffBytes = stackalloc byte[diffLength];
        _ = difference.TryWriteBytes(diffBytes, out diffLength, isUnsigned: true, isBigEndian: false);

        if (diffLength > BitOperation2.SourceSize)
        {
            throw new NotImplementedException($"Difference was larger than {BitOperation2.SourceSize}");
        }
        
        BitOperation2.Execute(destination, diffBytes[..diffLength]);
    }
}