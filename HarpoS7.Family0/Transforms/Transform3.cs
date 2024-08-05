using System.Runtime.InteropServices;

namespace HarpoS7.Family0.Transforms;

/// <summary>
/// Lookup table generation
/// </summary>
public static class Transform3
{
    public const int SourceSize = 0x10;
    public const int DestinationSize = 0x1000;

    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        if (destination.Length < DestinationSize)
        {
            throw new ArgumentException(
                $"The destination buffer is too small ({destination.Length} bytes, should be at least {DestinationSize})",
                nameof(destination));
        }
        if (source.Length < SourceSize)
        {
            throw new ArgumentException(
                $"The source buffer is too small ({source.Length} bytes, should be at least {SourceSize})",
                nameof(source));
        }

        var srcDwords = MemoryMarshal.Cast<byte, uint>(source);
        var dstDwords = MemoryMarshal.Cast<byte, uint>(destination);

        const int srcDwordsToCopy = 4;
        dstDwords[..srcDwordsToCopy].Clear();
        srcDwords[..srcDwordsToCopy].CopyTo(dstDwords[srcDwordsToCopy..]);
        
        // Include zeros in the span for cleaner index math
        var dstQDwords = MemoryMarshal.Cast<uint, UInt128>(dstDwords[..]);
        for (var i = 1; i < 128; i *= 2)
        {
            var multiplicand = dstQDwords[i];
            var product = multiplicand * 2;
            
            var msbSet = multiplicand >> 0x7F != 0;
            if (msbSet)
            {
                product ^= 0x01_0000_8005;
            }

            var productIndex = i * 2;
            dstQDwords[productIndex] = product;

            for (var j = 1; j < productIndex; ++j)
            {
                dstQDwords[productIndex + j] = dstQDwords[j] ^ product;
            }
        }
    }
}