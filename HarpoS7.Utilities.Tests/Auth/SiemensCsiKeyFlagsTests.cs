using HarpoS7.Utilities.Auth;

namespace HarpoS7.Utilities.Tests.Auth;

public class SiemensCsiKeyFlagsTests
{
    [Test]
    [TestCase(EPublicKeyFamily.S71500, 0x0000)]
    [TestCase(EPublicKeyFamily.S71200, 0x0100)]
    [TestCase(EPublicKeyFamily.PlcSim, 0x0300)]
    public void GetFamilyFlagsReturnsSiemensFamilyBits(
        EPublicKeyFamily keyFamily,
        int expected)
    {
        Assert.That(SiemensCsiKeyFlags.GetFamilyFlags(keyFamily), Is.EqualTo(expected));
    }

    [Test]
    [TestCase(EPublicKeyFamily.S71500, 0x0001)]
    [TestCase(EPublicKeyFamily.S71200, 0x0101)]
    [TestCase(EPublicKeyFamily.PlcSim, 0x0301)]
    public void GetSymmetricKeyFlagsCombinesFamilyWithSymmetricKeyType(
        EPublicKeyFamily keyFamily,
        int expected)
    {
        Assert.That(SiemensCsiKeyFlags.GetSymmetricKeyFlags(keyFamily), Is.EqualTo(expected));
    }

    [Test]
    [TestCase(EPublicKeyFamily.S71500, 0x0010)]
    [TestCase(EPublicKeyFamily.S71200, 0x0110)]
    [TestCase(EPublicKeyFamily.PlcSim, 0x0310)]
    public void GetCommPublicKeyFlagsCombinesFamilyWithCommPublicKeyType(
        EPublicKeyFamily keyFamily,
        int expected)
    {
        Assert.That(SiemensCsiKeyFlags.GetCommPublicKeyFlags(keyFamily), Is.EqualTo(expected));
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
        Assert.That(SiemensCsiKeyFlags.GetSiemensFamilyName(keyFamily), Is.EqualTo(expected));
    }

    [Test]
    public void GetFamilyFlagsRejectsUnknownFamily()
    {
        Assert.Throws<ArgumentException>(() => SiemensCsiKeyFlags.GetFamilyFlags((EPublicKeyFamily)0x02));
    }
}
