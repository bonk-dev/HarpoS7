using System.Numerics;
using HarpoS7.Family0.BitOperations;
using HarpoS7.Family0.Compatibility;
using HarpoS7.Family0.Exceptions;
using HarpoS7.Family0.Utils;

namespace HarpoS7.Family0.Transforms;

/// <summary>
/// Big integer transform - multiplication
/// </summary>
public static class BigIntMultiplication
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
        
        Span<byte> buffer1 = stackalloc byte[5 * sizeof(uint)];
        BigIntOperations.Prepare(buffer1, source1);
        
        Span<byte> buffer2 = stackalloc byte[5 * sizeof(uint)];
        BigIntOperations.Prepare(buffer2, source2);

        var buf1BigInteger = BigIntegerCompatibility.FromUnsignedLittleEndian(buffer1);
        var buf2BigInteger = BigIntegerCompatibility.FromUnsignedLittleEndian(buffer2);
        var product = buf1BigInteger * buf2BigInteger;

        var productLength = BigIntegerCompatibility.GetSignedByteCount(product);
        
        Span<byte> productBuffer = stackalloc byte[productLength];
        productLength = BigIntegerCompatibility.WriteLittleEndian(product, productBuffer, isUnsigned: true);

        // Compress max 2 times
        if (BigIntegerCompressor.Compress(productBuffer, out productLength) &&
            BigIntegerCompressor.Compress(productBuffer[..productLength], out productLength))
        {
            BigIntegerCompressor.FinalCompress(productBuffer[..productLength]);
        }

        BigIntOperations.Finalize(destination, productBuffer[..productLength]);
    }
}
