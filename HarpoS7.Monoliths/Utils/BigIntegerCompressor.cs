using System.Numerics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.BitOperations;

namespace HarpoS7.Monoliths.Utils;

public static class BigIntegerCompressor
{
    /// <summary>
    /// This shrinks the big integer (deals with overflows), so that the integer fits in the BitOperation2 function
    /// </summary>
    /// <param name="integerBuffer">Big integer bytes</param>
    /// <param name="length">New length of the big integer</param>
    /// <returns>True if compression is still needed</returns>
    public static bool Compress(Span<byte> integerBuffer, out int length)
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

            var product = overflowInt * 0x2F + compressedProduct;
            _ = product.TryWriteBytes(integerBuffer, out length, isUnsigned: true, isBigEndian: false);
        }

        return length > BitOperation2.SourceSize;
    }

    /// <summary>
    /// Ends the big integer compression (adds 0x2F to the first uint)
    /// </summary>
    /// <param name="integerBuffer">Big integer buffer</param>
    /// <exception cref="ArgumentException">Thrown when <see cref="integerBuffer"/> length is smaller or equal to <see cref="BitOperation2.SourceSize"/></exception>
    public static void FinalCompress(Span<byte> integerBuffer)
    {
        if (integerBuffer.Length <= BitOperation2.SourceSize)
        {
            throw new ArgumentException(
                $"This BigInteger does not need any compression (it is already smaller than or equal to {BitOperation2.SourceSize})",
                nameof(integerBuffer));
        }
        
        var productDwords = MemoryMarshal.Cast<byte, uint>(integerBuffer);
        productDwords[0] += 0x2F;
    }
}