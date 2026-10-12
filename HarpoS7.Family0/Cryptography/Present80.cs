using System.Buffers.Binary;
using System.Numerics;

namespace HarpoS7.Family0.Cryptography;

/// <summary>The Siemens variant of PRESENT-80: 31 rounds and final whitening.</summary>
internal static class Present80
{
    private static readonly byte[] Sbox = { 12, 5, 6, 11, 9, 0, 10, 13, 3, 14, 15, 8, 4, 7, 1, 2 };
    private static readonly BigInteger KeyMask = (BigInteger.One << 80) - 1;
    private static readonly BigInteger KeyOffset = BigInteger.Parse("087CA995217BA31853DCE", System.Globalization.NumberStyles.HexNumber);
    private static readonly ulong[,] SubstitutionPermutation = BuildTables();

    private static ulong[,] BuildTables()
    {
        var tables = new ulong[8, 256];
        for (var lane = 0; lane < 8; lane++)
        for (var value = 0; value < 256; value++)
        {
            var substituted = Sbox[value & 15] | Sbox[value >> 4] << 4;
            for (var bit = 0; bit < 8; bit++)
            {
                var position = lane * 8 + bit;
                if ((substituted & (1 << bit)) != 0)
                    tables[lane, value] |= 1UL << (position == 63 ? 63 : position * 16 % 63);
            }
        }
        return tables;
    }

    public static BigInteger ReadKey(ReadOnlySpan<byte> littleEndianHalf)
    {
        BigInteger key = 0;
        // A little-endian 80-bit half is read in network byte order by PRESENT.
        foreach (var value in littleEndianHalf.Slice(0, 10)) key = (key << 8) | value;
        return key;
    }

    public static void ExpandKey(BigInteger key, Span<ulong> keys)
    {
        keys[0] = (ulong)(key >> 16) ^ 0x0000081000000000UL;
        var register = Update(key ^ KeyOffset, 1);
        for (var round = 1; round < 32; round++)
        {
            keys[round] = (ulong)(register >> 16);
            register = Update(register, round + 1) ^ (round == 1 ? 0x40 : 0);
        }
    }

    private static BigInteger Update(BigInteger key, int round)
    {
        key = ((key << 61) | (key >> 19)) & KeyMask;
        return ((BigInteger)Sbox[(int)(key >> 76)] << 76 | (key & ((BigInteger.One << 76) - 1))) ^ ((BigInteger)round << 15);
    }

    public static void Encrypt(ReadOnlySpan<byte> block, Span<byte> destination, ReadOnlySpan<ulong> keys)
    {
        var state = BinaryPrimitives.ReadUInt64BigEndian(block);
        for (var round = 0; round < 31; round++)
        {
            state ^= keys[round];
            ulong next = 0;
            for (var lane = 0; lane < 8; lane++) next |= SubstitutionPermutation[lane, (byte)(state >> (lane * 8))];
            state = next;
        }
        BinaryPrimitives.WriteUInt64BigEndian(destination, state ^ keys[31]);
    }
}
