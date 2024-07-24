using System.Numerics;
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
}