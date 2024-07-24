using System.Buffers.Binary;
using System.Numerics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Exceptions;

namespace HarpoS7.Monoliths.Transforms;

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

        // Returns true if compression is still needed
        // This shrinks the big integer (deals with overflows), so that the integer fits in the BitOperation2 function 
        bool CompressBigInt(Span<byte> integerBuffer, out int length)
        {
            length = integerBuffer.Length;
            if (length > BitOperation2.SourceSize)
            {
                var overflowInt = new BigInteger(
                    integerBuffer[BitOperation2.SourceSize..],
                    isUnsigned: true,
                    isBigEndian: false);
                var compressedProduct = new BigInteger(
                    integerBuffer[..BitOperation2.SourceSize],
                    isUnsigned: true,
                    isBigEndian: false);

                product = overflowInt * 0x2F + compressedProduct;
                _ = product.TryWriteBytes(integerBuffer, out length, isUnsigned: true, isBigEndian: false);
            }

            return length > BitOperation2.SourceSize;
        }

        // Compress max 2 times
        if (CompressBigInt(productBuffer, out productLength) &&
            CompressBigInt(productBuffer[..productLength], out productLength))
        {
            var productDwords = MemoryMarshal.Cast<byte, uint>(productBuffer);
            productDwords[0] += 0x2F;
        }

        BitOperation2.Execute(destination, productBuffer[..productLength]);
    }
}