using System.Runtime.InteropServices;

namespace HarpoS7.Monoliths.Transforms;

public static class Transform4
{
    public const int KeySize = 0x10;
    public const int DestinationSize = 0x10;
    public const int LookupTableSize = Transform3.DestinationSize;

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

        Span<uint> workBuffer = stackalloc uint[8];
        workBuffer.Clear();

        var keyDwords = MemoryMarshal.Cast<byte, uint>(key);
        var lutDwords = MemoryMarshal.Cast<byte, uint>(lookupTable);

        for (var i = 0x18; i > 0; i -= 0x08)
        {
            for (var j = 0; j < 4; ++j)
            {
                var lutIndex = (int)(((keyDwords[j] >> i) & 0xFF) << 2);
                Xor128(workBuffer[j..], lutDwords[lutIndex..]);
            }

            for (var j = 7; j >= 1; --j)
            {
                workBuffer[j] = workBuffer[j - 1] >> 0x18 | workBuffer[j] << 0x08;
            }

            workBuffer[0] <<= 0x08;
        }
        
        for (var i = 0; i < 4; ++i)
        {
            var lutIndex = (int)((keyDwords[i] & 0xFF) << 2);
            Xor128(workBuffer[i..], lutDwords[lutIndex..]);
        }

        var dstDwords = MemoryMarshal.Cast<byte, uint>(destination);
        
        var temp = (workBuffer[7] >> 0x0D ^ workBuffer[7]) >> 0x11 ^ workBuffer[4] ^ workBuffer[7];
        dstDwords[0] = (temp << 0x0D ^ temp) << 0x02 ^ workBuffer[0] ^ temp;
        dstDwords[1] = (temp >> 0xd ^ temp) >> 0x11 ^ (workBuffer[5] << 0xd ^ workBuffer[5]) << 2 ^ workBuffer[1]
                        ^ temp ^ workBuffer[5];
        dstDwords[2] = (workBuffer[5] >> 0xd ^ workBuffer[5]) >> 0x11 ^ (workBuffer[6] << 0xd ^ workBuffer[6]) << 2 ^
                       workBuffer[2] ^ workBuffer[5] ^ workBuffer[6];
        dstDwords[3] = (workBuffer[6] >> 0xd ^ workBuffer[6]) >> 0x11 ^ (workBuffer[7] << 0xd ^ workBuffer[7]) << 2 ^
                       workBuffer[3] ^ workBuffer[6] ^ workBuffer[7];
    }

    /// <summary>
    /// Xors 4 32-bit DWords
    /// </summary>
    private static void Xor128(Span<uint> destinationSource, ReadOnlySpan<uint> xorB)
    {
        const int xorLength = 4;
        
        if (destinationSource.Length < xorLength)
        {
            throw new ArgumentException(
                $"The destination buffer was too small ({destinationSource.Length} dwords, it must be at least {xorLength} dwords)", 
                nameof(destinationSource));
        }
        if (xorB.Length < xorLength)
        {
            throw new ArgumentException(
                $"The XOR buffer was too small ({xorB.Length} dwords, it must be at least {xorLength} dwords)", 
                nameof(xorB));
        }

        for (var i = 0; i < xorLength; ++i)
        {
            destinationSource[i] ^= xorB[i];
        }
    }
}