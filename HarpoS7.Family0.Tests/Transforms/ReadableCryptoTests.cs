using System.Numerics;
using HarpoS7.Family0.Cryptography;
using HarpoS7.Family0.Compatibility;
using HarpoS7.Family0.Data;
using HarpoS7.Family0.Monoliths;
using HarpoS7.Family0.Transforms;
using HarpoS7.Family0.Tests.Utils;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Family0.Tests.Transforms;

public class ReadableCryptoTests
{
    private static byte[] Decode(ReadOnlySpan<byte> encoded)
    {
        var input = new byte[120];
        encoded.Slice(0, 60).CopyTo(input);
        var result = new byte[20];
        Monolith11.Execute(result, input);
        var offset = new byte[] { 0xA5, 0x4E, 0x33, 0xCF, 0x51, 0xEB, 0x9A, 0x1D };
        for (var i = 0; i < 20; i++) result[i] ^= offset[i % 8];
        return result;
    }

    [Test]
    public void PresentSeedAndKeysMatchOriginalForRandomAndBoundaryKeys()
    {
        var random = new Random(28);
        for (var sample = 0; sample < 40; sample++)
        {
            var key = new byte[24];
            if (sample == 1) key.AsSpan().Fill(255);
            else if (sample > 1) random.NextBytes(key);
            var encoded = new byte[60];
            PreSeedTransform.Execute(encoded, key);
            var decoded = new byte[20];
            LegacySeed.PreSeed(decoded, key);
            Assert.That(decoded, Is.EqualTo(Decode(encoded)), $"pre-seed {sample}");
            var expectedKeys = new byte[48];
            var actualKeys = new byte[48];
            KeyDerivationTransform.Execute(expectedKeys, encoded);
            LegacySeed.DeriveKeys(actualKeys, decoded);
            Assert.That(actualKeys, Is.EqualTo(expectedKeys), $"keys {sample}");

            var encodedMask = new byte[60];
            Transform13.Execute(encodedMask, encoded);
            var actualMask = new byte[20];
            LegacySeed.SeedMask(actualMask, decoded);
            Assert.That(actualMask, Is.EqualTo(Decode(encodedMask)), $"mask {sample}");
        }
    }

    [Test]
    public void DirectSeedMatchesCapturedVector()
    {
        var publicKey = File.ReadAllBytes(BlobUtils.GetTransformFilePath(6, "publicKey"));
        var encoded = File.ReadAllBytes(BlobUtils.GetTransformFilePath(6, "t1"));
        var expected = File.ReadAllBytes(BlobUtils.GetTransformDestinationPath(6));
        var result = new byte[60];
        try
        {
            SpanExtensions.StaticFillSequence = new byte[] { 0x2D };
            LegacySeed.WriteSeed(result, publicKey, Decode(encoded));
            Assert.That(result, Is.EqualTo(expected));
        }
        finally { SpanExtensions.ResetStaticSequence(); }
    }

    [Test]
    public void CurveMatchesOriginalForRandomScalars()
    {
        var random = new Random(28);
        for (var sample = 0; sample < 12; sample++)
        {
            var scalarBytes = new byte[20];
            var blinding = new byte[20];
            random.NextBytes(scalarBytes);
            random.NextBytes(blinding);
            var source = Transform7Data.Data.Span.Slice(0xD8, 40);
            var packed = new byte[Transform7.DestinationSize];
            Transform7.Execute(packed, blinding, scalarBytes, source);
            Monolith1.Loop(packed, packed);
            var expected = new byte[20];
            Monolith2.Execute(expected, packed);
            var scalar = BigIntegerCompatibility.FromUnsignedLittleEndian(scalarBytes) ^ LegacyCurve.ScalarMask;
            Assert.That(LegacyCurve.Multiply(scalar, LegacyCurve.GeneratorX),
                Is.EqualTo(BigIntegerCompatibility.FromUnsignedLittleEndian(expected)));
        }
    }

    [Test]
    public void CurveMatchesOriginalForEveryRealPlcCatalogueKey()
    {
        var directory = Path.Combine(TestContext.CurrentContext.TestDirectory, "CatalogueKeys");
        var files = Directory.GetFiles(directory, "*.bin", SearchOption.AllDirectories);
        Assert.That(files.Length, Is.EqualTo(16));
        var random = new Random(28);
        foreach (var file in files)
        {
            var source = File.ReadAllBytes(file);
            var scalarBytes = new byte[20];
            var blinding = new byte[20];
            random.NextBytes(scalarBytes);
            random.NextBytes(blinding);
            var packed = new byte[Transform7.DestinationSize];
            Transform7.Execute(packed, blinding, scalarBytes, source);
            Monolith1.Loop(packed, packed);
            var expected = new byte[20];
            Monolith2.Execute(expected, packed);
            var scalar = BigIntegerCompatibility.FromUnsignedLittleEndian(scalarBytes) ^ LegacyCurve.ScalarMask;
            Assert.That(LegacyCurve.Multiply(scalar, BigIntegerCompatibility.FromUnsignedLittleEndian(source.AsSpan(0, 20))),
                Is.EqualTo(BigIntegerCompatibility.FromUnsignedLittleEndian(expected)), Path.GetFileName(file));
        }
    }

    [Test]
    public void ChecksumMatchesPolynomialOracleIncludingHighBitsAndInPlaceWrites()
    {
        var random = new Random(28);
        for (var sample = 0; sample < 100; sample++)
        {
            var a = new byte[16];
            var b = new byte[16];
            if (sample == 1) { a.AsSpan().Fill(255); b.AsSpan().Fill(255); }
            else if (sample > 1) { random.NextBytes(a); random.NextBytes(b); }
            var multiplier = BigIntegerCompatibility.FromUnsignedLittleEndian(a);
            var multiplicand = BigIntegerCompatibility.FromUnsignedLittleEndian(b);
            BigInteger product = 0;
            for (var bit = 0; bit < 128; bit++)
                if (((multiplier >> bit) & 1) != 0) product ^= multiplicand << bit;
            var polynomial = (BigInteger.One << 128) | (BigInteger.One << 32) | (BigInteger.One << 15) | 5;
            for (var bit = 254; bit >= 128; bit--)
                if (((product >> bit) & 1) != 0) product ^= polynomial << (bit - 128);
            var lookup = new byte[LutGenerator.DestinationSize];
            LutGenerator.Execute(lookup, b);
            ChecksumTransform.Execute(a, a, lookup);
            Assert.That(BigIntegerCompatibility.FromUnsignedLittleEndian(a), Is.EqualTo(product));
        }
    }

    [Test]
    public void CurveHandlesInfinityIdentityAndDoublingAtStructuredX()
    {
        Assert.That(LegacyCurve.Multiply(0, 5), Is.EqualTo(BigInteger.Zero));
        Assert.That(LegacyCurve.Multiply(1, 5), Is.EqualTo(new BigInteger(5)));
        // Independent affine doubling formula for A=-1, including x=5 from issue #28.
        var p = LegacyCurve.Prime;
        var b = BigInteger.Parse("0FDEC56A0F1A148A7CA6F04463A24F5F56C3F3A4F", System.Globalization.NumberStyles.HexNumber);
        var expected = (74 * 74 * BigInteger.ModPow(4 * (125 - 5 + b) % p, p - 2, p) - 10) % p;
        Assert.That(LegacyCurve.Multiply(2, 5), Is.EqualTo((expected + p) % p));
    }
}
