using System.Buffers.Binary;
using System.Numerics;
using HarpoS7.Family0.Compatibility;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Family0.Cryptography;

/// <summary>Decoded seed and key derivation, without the white-box intermediate representation.</summary>
internal static class LegacySeed
{
    private static readonly BigInteger PreSeedKey = BigInteger.Parse("0A98DE7C5164AD032538F", System.Globalization.NumberStyles.HexNumber);
    private static readonly ulong[] KeyBlocks = { 0xEFFCB975BC8864FD, 0x20B6407AF0433F14, 0x610806EFE0358644, 0xFF78C6D5C660CEDC, 0xC5E88FDB01AF4AE1, 0x2AE2BA517C0D93F6 };
    private static readonly ulong[] MaskBlocks = { 0xF5EA1E69CBDF8EF1, 0xF4C52FEBC1C01D1A, 0xADF3602156A724DE };

    internal static void PreSeed(Span<byte> destination, ReadOnlySpan<byte> key1)
    {
        Span<ulong> keys = stackalloc ulong[32];
        Present80.ExpandKey(PreSeedKey, keys);
        Span<byte> result = stackalloc byte[24];
        for (var i = 0; i < 3; i++) Present80.Encrypt(key1.Slice(i * 8, 8), result.Slice(i * 8, 8), keys);
        result.Slice(0, 20).CopyTo(destination);
    }

    internal static void DeriveKeys(Span<byte> destination, ReadOnlySpan<byte> preSeed) => EncryptBlocks(destination, preSeed, KeyBlocks, 3);
    internal static void SeedMask(Span<byte> destination, ReadOnlySpan<byte> sharedX)
    {
        Span<byte> result = stackalloc byte[24];
        EncryptBlocks(result, sharedX, MaskBlocks, 2);
        result.Slice(0, 20).CopyTo(destination);
    }

    private static void EncryptBlocks(Span<byte> destination, ReadOnlySpan<byte> value, ulong[] blocks, int split)
    {
        Span<ulong> keys = stackalloc ulong[32];
        Span<byte> block = stackalloc byte[8];
        Present80.ExpandKey(Present80.ReadKey(value), keys);
        for (var i = 0; i < blocks.Length; i++)
        {
            if (i == split) Present80.ExpandKey(Present80.ReadKey(value.Slice(10)), keys);
            BinaryPrimitives.WriteUInt64LittleEndian(block, blocks[i]);
            Present80.Encrypt(block, destination.Slice(i * 8, 8), keys);
        }
    }

    internal static void WriteSeed(Span<byte> destination, ReadOnlySpan<byte> publicKey, ReadOnlySpan<byte> preSeed)
    {
        // Keep the wire field and random-byte consumption order of SeedTransform.
        Span<byte> blinding = stackalloc byte[20];
        Span<byte> random = stackalloc byte[20];
        blinding.FillWithCryptoRandomBytes();
        BigInteger scalar, ephemeral;
        do
        {
            random.FillWithCryptoRandomBytes();
            scalar = BigIntegerCompatibility.FromUnsignedLittleEndian(random) ^ LegacyCurve.ScalarMask;
            ephemeral = LegacyCurve.Multiply(scalar, LegacyCurve.GeneratorX);
        } while (ephemeral.IsZero);

        var shared = LegacyCurve.Multiply(scalar, BigIntegerCompatibility.FromUnsignedLittleEndian(publicKey.Slice(0, 20)));
        Span<byte> sharedBytes = stackalloc byte[20];
        sharedBytes.Clear();
        BigIntegerCompatibility.WriteLittleEndian(shared, sharedBytes, true);
        SeedMask(destination, sharedBytes);
        for (var i = 0; i < 20; i++) destination[i] ^= preSeed[i];
        destination.Slice(20, 20).Clear();
        BigIntegerCompatibility.WriteLittleEndian(ephemeral, destination.Slice(20, 20), true);
        blinding.CopyTo(destination.Slice(40, 20));
    }
}
