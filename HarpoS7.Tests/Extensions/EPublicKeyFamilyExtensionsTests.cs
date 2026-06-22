using HarpoS7.Extensions;
using HarpoS7.Utilities.Auth;

namespace HarpoS7.Tests.Extensions;

public class EPublicKeyFamilyExtensionsTests
{
    [Test]
    [TestCase("00AABBCC", EPublicKeyFamily.S71500)]
    [TestCase("01AABBCC", EPublicKeyFamily.S71200)]
    [TestCase("03AABBCC", EPublicKeyFamily.PlcSim)]
    public void ToPublicKeyFamilyParsesKnownFingerprintPrefixes(
        string fingerprint,
        EPublicKeyFamily expected)
    {
        Assert.That(fingerprint.ToPublicKeyFamily(), Is.EqualTo(expected));
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("0")]
    [TestCase("AB")]
    [TestCase("02AABBCC")]
    public void ToPublicKeyFamilyRejectsInvalidFingerprintPrefixes(string? fingerprint)
    {
        Assert.Throws<ArgumentException>(() => fingerprint!.ToPublicKeyFamily());
    }

    [Test]
    [TestCase(EPublicKeyFamily.S71500, "KeyFamilyCPU1500")]
    [TestCase(EPublicKeyFamily.S71200, "KeyFamilyCPU1200")]
    [TestCase(EPublicKeyFamily.PlcSim, "KeyFamilyVPLC")]
    [TestCase((EPublicKeyFamily)0x02, "UnknownKeyFamily(2)")]
    public void GetSiemensFamilyNameReturnsKnownOrFallbackName(
        EPublicKeyFamily keyFamily,
        string expected)
    {
        Assert.That(keyFamily.GetSiemensFamilyName(), Is.EqualTo(expected));
    }
}
