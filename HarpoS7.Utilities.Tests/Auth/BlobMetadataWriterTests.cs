using HarpoS7.Utilities.Auth;

namespace HarpoS7.Utilities.Tests.Auth;

public class BlobMetadataWriterTests
{
    [Test]
    [TestCase(EPublicKeyFamily.S71500, 180, 0x0001, 0x0010)]
    [TestCase(EPublicKeyFamily.S71200, 180, 0x0101, 0x0110)]
    [TestCase(EPublicKeyFamily.PlcSim, 216, 0x0301, 0x0310)]
    public void WriteMetadataWritesExpectedHeaderAndFlags(
        EPublicKeyFamily keyFamily,
        int expectedBlobLength,
        int expectedSymmetricKeyFlags,
        int expectedPublicKeyFlags)
    {
        var publicKey = new byte[64];
        var key1 = new byte[24];
        var destination = new byte[BlobMetadataWriter.GetBlobLength(keyFamily)];

        var offset = BlobMetadataWriter.WriteMetadata(
            destination,
            publicKey,
            key1,
            keyFamily);

        Assert.That(offset, Is.EqualTo(48));
        Assert.That(BitConverter.ToUInt32(destination, 0), Is.EqualTo(0xFEE1DEAD));
        Assert.That(BitConverter.ToUInt32(destination, 4), Is.EqualTo((uint)expectedBlobLength));
        Assert.That(BitConverter.ToUInt32(destination, 8), Is.EqualTo(1U));
        Assert.That(BitConverter.ToUInt32(destination, 12), Is.EqualTo(1U));
        Assert.That(BitConverter.ToUInt32(destination, 24), Is.EqualTo((uint)expectedSymmetricKeyFlags));
        Assert.That(BitConverter.ToUInt32(destination, 28), Is.EqualTo(0U));
        Assert.That(BitConverter.ToUInt32(destination, 40), Is.EqualTo((uint)expectedPublicKeyFlags));
        Assert.That(BitConverter.ToUInt32(destination, 44), Is.EqualTo(0U));
    }

    [Test]
    public void WriteMetadataRejectsShortPublicKey()
    {
        var publicKey = new byte[CommonConstants.PublicKeyLengthRealPlc - 1];
        var key1 = new byte[24];
        var destination = new byte[CommonConstants.EncryptedBlobLengthRealPlc];

        Assert.Throws<ArgumentException>(() => BlobMetadataWriter.WriteMetadata(
            destination,
            publicKey,
            key1,
            EPublicKeyFamily.S71500));
    }

    [Test]
    [TestCase(EPublicKeyFamily.S71500, 124, 60, 0x0001, 0x0001, 0x0010)]
    [TestCase(EPublicKeyFamily.S71200, 124, 60, 0x0101, 0x0001, 0x0110)]
    [TestCase(EPublicKeyFamily.PlcSim, 160, 96, 0x0301, 0x0301, 0x0310)]
    public void LengthAndFlagHelpersReturnFamilySpecificValues(
        EPublicKeyFamily keyFamily,
        int expectedSeedFragmentLength,
        int expectedEncryptedSeedLength,
        int expectedSymmetricKeyFlags,
        int expectedLegitimationSymmetricKeyFlags,
        int expectedPublicKeyFlags)
    {
        Assert.That(BlobMetadataWriter.GetLegitimationSeedFragmentLength(keyFamily), Is.EqualTo(expectedSeedFragmentLength));
        Assert.That(BlobMetadataWriter.GetEncryptedSeedLength(keyFamily), Is.EqualTo(expectedEncryptedSeedLength));
        Assert.That(BlobMetadataWriter.GetSymmetricKeyFlags(keyFamily), Is.EqualTo(expectedSymmetricKeyFlags));
        Assert.That(BlobMetadataWriter.GetSymmetricKeyFlagsLegitimation(keyFamily), Is.EqualTo(expectedLegitimationSymmetricKeyFlags));
        Assert.That(BlobMetadataWriter.GetPublicKeyFlags(keyFamily), Is.EqualTo(expectedPublicKeyFlags));
    }

    [Test]
    public void HelpersRejectUnknownFamily()
    {
        const EPublicKeyFamily unknownFamily = (EPublicKeyFamily)0x02;

        Assert.Throws<ArgumentException>(() => BlobMetadataWriter.GetBlobLength(unknownFamily));
        Assert.Throws<ArgumentException>(() => BlobMetadataWriter.GetLegitimationSeedFragmentLength(unknownFamily));
        Assert.Throws<ArgumentException>(() => BlobMetadataWriter.GetEncryptedSeedLength(unknownFamily));
        Assert.Throws<ArgumentException>(() => BlobMetadataWriter.GetSymmetricKeyFlags(unknownFamily));
        Assert.Throws<ArgumentException>(() => BlobMetadataWriter.GetSymmetricKeyFlagsLegitimation(unknownFamily));
        Assert.Throws<ArgumentException>(() => BlobMetadataWriter.GetPublicKeyFlags(unknownFamily));
    }

    [Test]
    [TestCase(
        new byte[] {
            0x47, 0x00, 0xDB, 0x8F, 0xA2, 0x5D, 0x79, 0x1C,
            0x2A, 0x77, 0xEE, 0xC9, 0x79, 0x5D, 0x66, 0xE3,
            0xB5, 0xF2, 0xBA, 0x9A, 0x59, 0x50, 0x8A, 0xDD,
            0x51, 0x0C, 0xA9, 0xFE, 0x87, 0x62, 0xAA, 0x08,
            0x1D, 0xFF, 0x80, 0xEA, 0x8F, 0x73, 0x0A, 0xD4,
            0xCA, 0xA0, 0xBC, 0xA7, 0xBA, 0x92, 0x89, 0x2C,
            0x69, 0x19, 0x84, 0x33, 0x8E, 0xEC, 0x20, 0x47,
            0x68, 0x1D, 0x95, 0x8D, 0xC5, 0xC5, 0x08, 0x6A
        }, 
        EPublicKeyFamily.PlcSim,
        new byte[] {
            0xA4, 0x3A, 0x36, 0x8E, 0xBD, 0xD2, 0xD2, 0x9A,
            0x28, 0x1C, 0xBF, 0xC8, 0x22, 0xEB, 0xD8, 0x4B,
            0x37, 0x8E, 0xF4, 0x5D, 0xC5, 0xE5, 0x27, 0x8E           
        }, 
        new byte[BlobMetadataWriter.BeefSeedMetadataLength] {
            0xEF, 0xBE, 0xAD, 0xDE, 0xA0, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xCA, 0x4A, 0xAA, 0x9C,
            0xAC, 0x54, 0x76, 0xB0, 0x10, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x7C, 0x5F, 0xE4, 0x0F,
            0xD8, 0xB8, 0xF7, 0xCA, 0x01, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00
        })]
    public void WriteSeedBeefMetadata(
        byte[] publicKey,
        EPublicKeyFamily keyFamily,
        byte[] symmetricKey,
        byte[] expected)
    {
        var destination = new byte[BlobMetadataWriter.BeefSeedMetadataLength];
        BlobMetadataWriter.WriteSeedBeefMetadata(
            destination, 
            publicKey, 
            keyFamily,
            symmetricKey
        );
        
        Assert.That(destination, Is.EqualTo(expected));
    }
}
