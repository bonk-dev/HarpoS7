namespace HarpoS7.Family0.Transforms;

public static class ChecksumTransform
{
    public const int KeySize = 0x10;
    public const int DestinationSize = 0x10;
    public const int LookupTableSize = LutGenerator.DestinationSize;

    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> key, ReadOnlySpan<byte> lookupTable)
    {
        if (destination.Length < DestinationSize)
        {
            throw new ArgumentException(
                $"The destination buffer is too small ({destination.Length} bytes, should be at least {DestinationSize})",
                nameof(destination));
        }
        if (key.Length < KeySize)
        {
            throw new ArgumentException(
                $"The key buffer is too small ({key.Length} bytes, should be at least {KeySize})",
                nameof(key));
        }
        if (lookupTable.Length < LookupTableSize)
        {
            throw new ArgumentException(
                $"The lookup table buffer is too small ({lookupTable.Length} bytes, should be at least {LookupTableSize})",
                nameof(lookupTable));
        }

        Multiply(destination, key, lookupTable.Slice(16, 16));
    }

    internal static void Multiply(Span<byte> destination, ReadOnlySpan<byte> key, ReadOnlySpan<byte> hashKey)
    {
        // Values use little-endian polynomial coefficients.
        var aLow = System.Buffers.Binary.BinaryPrimitives.ReadUInt64LittleEndian(key);
        var aHigh = System.Buffers.Binary.BinaryPrimitives.ReadUInt64LittleEndian(key.Slice(8));
        var bLow = System.Buffers.Binary.BinaryPrimitives.ReadUInt64LittleEndian(hashKey);
        var bHigh = System.Buffers.Binary.BinaryPrimitives.ReadUInt64LittleEndian(hashKey.Slice(8));
        ulong low = 0, high = 0;
        for (var bit = 0; bit < 128; bit++)
        {
            var mask = 0UL - (bLow & 1);
            low ^= aLow & mask;
            high ^= aHigh & mask;
            bLow = (bLow >> 1) | (bHigh << 63);
            bHigh >>= 1;
            var carry = aHigh >> 63;
            aHigh = (aHigh << 1) | (aLow >> 63);
            // x^128 + x^32 + x^15 + x^2 + 1 (not the GCM field).
            aLow = (aLow << 1) ^ (0x100008005UL & (0UL - carry));
        }
        System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(destination, low);
        System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(destination.Slice(8), high);
    }
}
