using System.Runtime.InteropServices;

namespace HarpoS7.Aes;

public static class HarpoHash
{
    public static void Lut1(Span<uint> output, Span<uint> a1)
    {
        uint t1 = a1[3];

        uint index = ((t1 >> 0x11) & 0x80808080) * 2;
        ushort t2 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(
            AesConsts.LutSeed[(int)index..].Span);

        uint LutSeedInit(uint val1)
        {
            return (((val1 >> 0x11) | (t1 << 0xF)) ^ t1 >> 1) & 0x7F7F7F7F ^ (val1 >> 0x11 | t1 << 0xF);
        }

        output[3] = LutSeedInit(a1[2]);

        t1 = a1[2];
        output[2] = LutSeedInit(a1[1]);

        t1 = a1[1];
        output[1] = LutSeedInit(a1[0]);

        t1 = a1[0];
        uint t3 = (t1 << 0xF ^ t1 >> 1) & 0x7F7F7F7F ^ t1 << 0xF ^ Convert.ToUInt32(t2);
        output[0] = t3;
    }

    public static void GenerateLookupTable(ReadOnlySpan<byte> key, Span<uint> destination)
    {
        // fill 16 bytes with 0
        destination[..4].Fill(0x00);

        // copy the 16 byte key to destination offset 0x800
        MemoryMarshal
            .Cast<byte, uint>(key)
            .CopyTo(destination[0x200..]);

        int index = 0x40;
        do
        {
            Lut1(destination[(index * 4)..], destination[(index * 8)..]);

            index >>= 1;
        } while (index != 0);

        index = 2;
        do
        {
            if (index > 1)
            {
                int j = (index << 4);
                int k = index - 1;
                int dest1 = (0x18 + j) / sizeof(uint);
                int dest2 = 0x18 / sizeof(uint);
                int l = j / sizeof(uint);

                do
                {
                    destination[dest1 - 2] = destination[dest2 - 2] ^ destination[l];
                    destination[dest1 - 1] = destination[dest2 - 1] ^ destination[l + 1];
                    destination[dest1] = destination[dest2] ^ destination[l + 2];
                    destination[dest1 + 1] = destination[dest2 + 1] ^ destination[l + 3];

                    dest1 += sizeof(uint);
                    dest2 += sizeof(uint);
                } while (--k != 0);
            }

            index *= 2;
        } while (index < 0x100);
    }

    public static void Hash(Span<byte> output, ReadOnlySpan<byte> lut)
    {
        // Shoup table entry 0x80 is the original GHASH multiplier H.
        Multiply(output, lut.Slice(0x800, 16));
    }

    internal static void Multiply(Span<byte> output, ReadOnlySpan<byte> h)
    {
        var vHigh = System.Buffers.Binary.BinaryPrimitives.ReadUInt64BigEndian(h);
        var vLow = System.Buffers.Binary.BinaryPrimitives.ReadUInt64BigEndian(h.Slice(8));
        ulong zHigh = 0, zLow = 0;
        for (var bit = 0; bit < 128; bit++)
        {
            var mask = 0UL - (ulong)((output[bit / 8] >> (7 - bit % 8)) & 1);
            zHigh ^= vHigh & mask;
            zLow ^= vLow & mask;
            var carry = vLow & 1;
            vLow = (vLow >> 1) | (vHigh << 63);
            // GCM polynomial x^128 + x^7 + x^2 + x + 1, reflected bit order.
            vHigh = (vHigh >> 1) ^ (0xE100000000000000UL & (0UL - carry));
        }
        System.Buffers.Binary.BinaryPrimitives.WriteUInt64BigEndian(output, zHigh);
        System.Buffers.Binary.BinaryPrimitives.WriteUInt64BigEndian(output.Slice(8), zLow);
    }
}
