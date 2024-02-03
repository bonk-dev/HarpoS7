using System.Runtime.InteropServices;

namespace HarpoS7.Aes;

public static class HarpoHash
{
    public static void Lut1(Span<uint> output, Span<uint> a1)
    {
        uint t1 = a1[3];

        uint index = ((t1 >> 0x11) & 0x80808080) * 2;
        ushort t2 = BitConverter.ToUInt16(AesConsts.LutSeed[(int)index..].Span);

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
        uint t1 = 0;
        uint t2 = 0;
        uint t3 = 0;
        uint t4 = 0;

        ReadOnlySpan<uint> lutDword = MemoryMarshal.Cast<byte, uint>(lut);

        for (int i = 15; i >= 0; --i)
        {
            uint v1 = t3 >> 0x18;
            uint v2 = t2 >> 0x18;
            uint v3 = t1 >> 0x18;
            uint v4 = output[i];

            uint t5 = (v4 << 4) / 4;

            t1 = (t1 << 8) ^ AesConsts.HarpoHashSeed.Span[(int)(t4 >> 0x18)] ^ lutDword[(int)t5];
            t2 = ((t2 << 8) | v3) ^ lutDword[(int)t5 + 1];
            t3 = ((t3 << 8) | v2) ^ lutDword[(int)t5 + 2];
            t4 = ((t4 << 8) | v1) ^ lutDword[(int)t5 + 3];
        }

        var outputAsDword = MemoryMarshal.Cast<byte, uint>(output);
        outputAsDword[0] = t1;
        outputAsDword[1] = t2;
        outputAsDword[2] = t3;
        outputAsDword[3] = t4;
    }
}