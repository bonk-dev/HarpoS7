using HarpoS7.Aes;

namespace HarpoS7.Tests.Aes;

public class ReadableGcmTests
{
    [Test]
    public void CounterWrapsOnlyItsLastThreeBytes()
    {
        using var cipher = new HarpoAesCtr(new byte[16]);
        cipher.Init(new byte[12]);
        var counter = (byte[])typeof(HarpoAesCtr).GetField("_counter",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)!.GetValue(cipher)!;
        counter[12] = 0xAA;
        counter[13] = counter[14] = counter[15] = 255;
        var expectedCounter = (byte[])counter.Clone();
        expectedCounter[13] = expectedCounter[14] = expectedCounter[15] = 0;
        var expected = new byte[16];
        using var ecb = new HarpoAes(new byte[16]);
        ecb.EncryptEcb(expectedCounter, expected);
        var actual = new byte[16];
        cipher.EncryptCtr(new byte[16], actual);
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(counter[12], Is.EqualTo(0xAA));
    }

    [Test]
    public void NistZeroKeyVectorWorksAcrossPartialWritesAndRepeatedTags()
    {
        using var cipher = new HarpoAesCtr(new byte[16]);
        cipher.Init(new byte[12]);
        var result = new byte[16];
        cipher.EncryptCtr(new byte[3], result.AsSpan(0, 3));
        cipher.EncryptCtr(ReadOnlySpan<byte>.Empty, Span<byte>.Empty);
        cipher.EncryptCtr(new byte[5], result.AsSpan(3, 5));
        cipher.EncryptCtr(new byte[8], result.AsSpan(8, 8));
        Assert.That(result, Is.EqualTo(Hex("0388dace60b6a392f328c2b971b2fe78")));
        var tag = new byte[16];
        cipher.CalculateChecksum(tag);
        Assert.That(tag, Is.EqualTo(Hex("ab6e47d42cec13bdf53a67b21257bddf")));
        cipher.CalculateChecksum(tag);
        Assert.That(tag, Is.EqualTo(Hex("ab6e47d42cec13bdf53a67b21257bddf")));
        cipher.Init(new byte[12]);
        cipher.CalculateChecksum(tag);
        Assert.That(tag, Is.EqualTo(Hex("58e2fccefa7e3061367f1d57a4e7455a")));
    }

    [TestCase(12)]
    [TestCase(16)]
    [TestCase(23)]
    [TestCase(32)]
    public void ChunkedAndInPlaceEncryptionMatchesSingleWrite(int ivLength)
    {
        var random = new Random(28);
        var key = new byte[16];
        var iv = new byte[ivLength];
        var plaintext = new byte[131];
        random.NextBytes(key);
        random.NextBytes(iv);
        random.NextBytes(plaintext);
        using var single = new HarpoAesCtr(key);
        using var chunked = new HarpoAesCtr(key);
        single.Init(iv);
        chunked.Init(iv);
        var expected = new byte[plaintext.Length];
        single.EncryptCtr(plaintext, expected);
        var actual = (byte[])plaintext.Clone();
        for (var offset = 0; offset < actual.Length;)
        {
            var count = Math.Min(7, actual.Length - offset);
            chunked.EncryptCtr(actual.AsSpan(offset, count), actual.AsSpan(offset, count));
            offset += count;
        }
        var tag = new byte[16];
        var expectedTag = new byte[16];
        single.CalculateChecksum(expectedTag);
        chunked.CalculateChecksum(tag);
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(tag, Is.EqualTo(expectedTag));
    }

#if NET8_0_OR_GREATER
    [Test]
    public void MatchesPlatformGcmForRandomKeysAndPartialMessages()
    {
        var random = new Random(28);
        for (var length = 0; length < 100; length++)
        {
            var key = new byte[16];
            var nonce = new byte[12];
            var input = new byte[length];
            random.NextBytes(key);
            random.NextBytes(nonce);
            random.NextBytes(input);
            using var platform = new System.Security.Cryptography.AesGcm(key, 16);
            var expected = new byte[length];
            var expectedTag = new byte[16];
            platform.Encrypt(nonce, input, expected, expectedTag);
            using var cipher = new HarpoAesCtr(key);
            cipher.Init(nonce);
            var actual = new byte[length];
            var tag = new byte[16];
            cipher.EncryptCtr(input, actual);
            cipher.CalculateChecksum(tag);
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(tag, Is.EqualTo(expectedTag));
        }
    }
#endif

    private static byte[] Hex(string value) => Enumerable.Range(0, value.Length / 2)
        .Select(i => Convert.ToByte(value.Substring(i * 2, 2), 16)).ToArray();
}
