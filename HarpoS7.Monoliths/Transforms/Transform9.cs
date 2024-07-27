using System.Buffers.Binary;
using System.Numerics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Exceptions;
using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Transforms;

/// <summary>
/// Big integer transform - multiplication
/// </summary>
public static class Transform9
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
        
        Span<byte> buffer1 = stackalloc byte[5 * sizeof(uint)];
        BitOperation1.Execute(buffer1, source1);
        
        Span<byte> buffer2 = stackalloc byte[5 * sizeof(uint)];
        BitOperation1.Execute(buffer2, source2);

        var buf1BigInteger = new BigInteger(buffer1, isUnsigned: true, isBigEndian: false);
        var buf2BigInteger = new BigInteger(buffer2, isUnsigned: true, isBigEndian: false);
        var product = buf1BigInteger * buf2BigInteger;

        var productLength = product.GetByteCount();
        
        Span<byte> productBuffer = stackalloc byte[productLength];
        _ = product.TryWriteBytes(productBuffer, out _, isUnsigned: true, isBigEndian: false);

        // Compress max 2 times
        if (BigIntegerCompressor.Compress(productBuffer, out productLength) &&
            BigIntegerCompressor.Compress(productBuffer[..productLength], out productLength))
        {
            BigIntegerCompressor.FinalCompress(productBuffer[..productLength]);
        }

        BitOperation2.Execute(destination, productBuffer[..productLength]);
    }
}