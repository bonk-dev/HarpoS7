using System.Numerics;
using HarpoS7.Family0.BitOperations;
using HarpoS7.Family0.Compatibility;
using HarpoS7.Family0.Exceptions;
using HarpoS7.Family0.Utils;

namespace HarpoS7.Family0.Transforms;

/// <summary>
/// Big integer transform - raise int to the power of 2
/// </summary>
public static class BigIntSquare
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

        var baseInt = BigIntegerCompatibility.FromUnsignedLittleEndian(op1Buffer);
        var result = BigInteger.Pow(baseInt, 2);

        var length = BigIntegerCompatibility.GetSignedByteCount(result);
        Span<byte> productBuffer = stackalloc byte[length];
        length = BigIntegerCompatibility.WriteLittleEndian(result, productBuffer, isUnsigned: true);

        if (BigIntegerCompressor.Compress(productBuffer[..length], out length) && 
            BigIntegerCompressor.Compress(productBuffer[..length], out length))
        {
            BigIntegerCompressor.FinalCompress(productBuffer[..length]);
        }
        
        BigIntOperations.Finalize(destination, productBuffer[..length]);
    }
}
