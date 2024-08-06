using CommunityToolkit.HighPerformance.Buffers;
using HarpoS7.Integrity;

namespace HarpoS7.Tests.Integrity;

public class HarpoPacketDigestTests
{
    [Test]
    [TestCase(
        new byte[24] 
        { 
            0xa2, 0x33, 0x87, 0x5e, 0x3c, 0x7f, 0xc0, 0x59, 0xc0, 0x16, 0x12, 0x8d, 
            0xe5, 0x90, 0xab, 0x3c, 0x28, 0xbc, 0x04, 0xc2, 0x77, 0xfa, 0x7c, 0x51 
        },
        new byte[0x2F] 
        {
            0x31, 0x00, 0x00, 0x04, 0xD4, 0x00, 0x00, 0x00, 0x03, 0x70, 0x40, 0x00,
            0x00, 0x34, 0x70, 0x40, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0xE8, 0x89,
            0x69, 0x00, 0x12, 0x00, 0x00, 0x00, 0x00, 0x89, 0x6A, 0x00, 0x13, 0x00,
            0x89, 0x6B, 0x00, 0x04, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00
        },
        new byte[HarpoPacketDigest.DigestLength] 
        {
            0x44, 0xe6, 0x81, 0xf7, 0xe9, 0x15, 0xba, 0xfa, 0x3b, 0x8c, 0x9e, 0xac, 
            0xb9, 0xd1, 0xf6, 0xbb, 0x47, 0xeb, 0xf1, 0x46, 0x9c, 0x49, 0xc4, 0x1e,
            0xfb, 0x6f, 0xc8, 0x15, 0x6d, 0x35, 0x42, 0x6a
        })]
    [TestCase(
        new byte[24]
        {
            0x4E, 0xAF, 0x8D, 0x97, 0x1F, 0xFC, 0xF4, 0x5A, 0x99, 0x59, 0x47, 0xCC,
            0x06, 0xBF, 0xF8, 0x5B, 0x0A, 0x2D, 0xF1, 0xBA, 0x6F, 0x3A, 0xE9, 0x4D
        },
        new byte[0x2F]
        {
            0x31, 0x00, 0x00, 0x04, 0xD4, 0x00, 0x00, 0x00, 0x03, 0x70, 0x00, 0x10,
            0x3D, 0x34, 0x70, 0x00, 0x10, 0x3D, 0x00, 0x00, 0x00, 0x04, 0xE8, 0x89,
            0x69, 0x00, 0x12, 0x00, 0x00, 0x00, 0x00, 0x89, 0x6A, 0x00, 0x13, 0x00,
            0x89, 0x6B, 0x00, 0x04, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00
        }, new byte[HarpoPacketDigest.DigestLength]
        {
            0x30, 0xCB, 0x4A, 0x65, 0xDE, 0x8A, 0x03, 0xC3, 0xA1, 0xA2, 0x90, 0x53,
            0x7C, 0x23, 0xC6, 0xE3, 0x6D, 0xB1, 0x2D, 0x9B, 0xBF, 0x3C, 0xCD, 0xE1,
            0x21, 0x2C, 0x54, 0xEA, 0x42, 0x1C, 0x5F, 0xC3
        })]
    [TestCase(
        new byte[]
        {
            0x65, 0xC4, 0xF1, 0x79, 0x98, 0x0A, 0x43, 0xCB, 0x60, 0xE1, 0x19, 0x4B, 
            0xA5, 0x00, 0xF5, 0xB9, 0xD0, 0x4F, 0x37, 0x4B, 0x56, 0x37, 0x48, 0x66
        },
        new byte[]
        {
            0x31, 0x00, 0x00, 0x04, 0xD4, 0x00, 0x00, 0x00, 0x03, 0x70, 0x00, 0x10,
            0x3D, 0x34, 0x70, 0x00, 0x10, 0x3D, 0x00, 0x00, 0x00, 0x04, 0xE8, 0x89,
            0x69, 0x00, 0x12, 0x00, 0x00, 0x00, 0x00, 0x89, 0x6A, 0x00, 0x13, 0x00,
            0x89, 0x6B, 0x00, 0x04, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00
        },
        new byte[HarpoPacketDigest.DigestLength]
        {
            0xA8, 0xBB, 0x3F, 0x23, 0x6A, 0xFA, 0xD6, 0x77, 0x4F, 0x44, 0x87, 0x13,
            0x6D, 0x00, 0x55, 0x77, 0x14, 0x22, 0xDE, 0xF8, 0xEA, 0x86, 0x2A, 0x8C,
            0x90, 0xD2, 0xD0, 0xB5, 0x4B, 0x19, 0x51, 0xF1
        }, Description = "Family0 session key")]
    public void CalculateDigest(byte[] sessionKey, byte[] data, byte[] expectedDigest)
    {
        Span<byte> digestBuffer = stackalloc byte[HarpoPacketDigest.DigestLength];
        HarpoPacketDigest.CalculateDigest(digestBuffer, data, sessionKey);

        Assert.That(digestBuffer.ToArray(), Is.EqualTo(expectedDigest));
    }
}