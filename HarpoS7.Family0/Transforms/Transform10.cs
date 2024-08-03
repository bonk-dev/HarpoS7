using System.Numerics;
using HarpoS7.Family0.BitOperations;
using HarpoS7.Family0.Exceptions;
using HarpoS7.Family0.Utils;

namespace HarpoS7.Family0.Transforms;

/// <summary>
/// Big integer transform - raise int to the power of 2
/// </summary>
public static class Transform10
{
    public const int DestinationSize = BigIntOperations.FinalizeDestinationSize;
    public const int SourceSize = BigIntOperations.PrepareSourceSize;
    
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
        
        Span<byte> op1Buffer = stackalloc byte[BigIntOperations.PrepareDestinationSize];
        BigIntOperations.Prepare(op1Buffer, source);

        var baseInt = new BigInteger(op1Buffer, isUnsigned: true, isBigEndian: false);
        var result = BigInteger.Pow(baseInt, 2);

        var length = result.GetByteCount();
        Span<byte> productBuffer = stackalloc byte[length];
        _ = result.TryWriteBytes(productBuffer, out _, isUnsigned: true, isBigEndian: false);

        if (BigIntegerCompressor.Compress(productBuffer[..length], out length) && 
            BigIntegerCompressor.Compress(productBuffer[..length], out length))
        {
            BigIntegerCompressor.FinalCompress(productBuffer[..length]);
        }
        
        BigIntOperations.Finalize(destination, productBuffer[..length]);
    }
}