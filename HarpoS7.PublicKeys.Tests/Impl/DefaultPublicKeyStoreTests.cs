using HarpoS7.PublicKeys.Impl;

namespace HarpoS7.PublicKeys.Tests.Impl;

public class DefaultPublicKeyStoreTests
{
    [Test]
    [TestCase("00:181B7B0847D11694", 40)]
    public void GetPublicKeyLengthTest(string variableNameFingerprint, int expected)
    {
        var store = new DefaultPublicKeyStore();
        var length = store.GetPublicKeyLength(variableNameFingerprint);
        Assert.That(length, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(
        "00:181B7B0847D11694",
        new byte[]
        {
            0x84, 0x56, 0xA2, 0x69, 0x96, 0x12, 0x22, 0x16, 0xC9, 0x21, 0xC5, 0x71,
            0xFF, 0x11, 0xE0, 0xBE, 0xFA, 0xFD, 0xB1, 0xD7, 0x0B, 0x5D, 0x4B, 0xC8,
            0x39, 0x0F, 0x5B, 0x0C, 0xC2, 0x73, 0xEC, 0x14, 0x2A, 0x03, 0xF2, 0xA0,
            0x4E, 0x6F, 0x15, 0x93
        })]
    public void ReadPublicKeyTest(string variableNameFingerprint, byte[] expected)
    {
        var store = new DefaultPublicKeyStore();
        var publicKey = new byte[store.GetPublicKeyLength(variableNameFingerprint)];
        store.ReadPublicKey(publicKey.AsSpan(), variableNameFingerprint);
        
        Assert.That(publicKey, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("00:181B7B0847D11694", "181B7B0847D11694")]
    public void GetKeyIdTest(string variableNameFingerprint, string expectedKeyId)
    {
        Assert.That(DefaultPublicKeyStore.GetKeyId(variableNameFingerprint), Is.EqualTo(expectedKeyId));
    }
}