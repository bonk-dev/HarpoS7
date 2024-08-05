using System.Diagnostics.CodeAnalysis;
using HarpoS7.Auth;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Tests.Auth;

public class LegacyAuthenticationSchemeTests
{
    [Test]
    [TestCase(
        new byte[]
        {
            0xAD, 0xDE, 0xE1, 0xFE, 0xB4, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x4E, 0x0C, 0x31, 0x3B, 0x5E, 0x08, 0xE4, 0x3B,
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x94, 0x16, 0xD1, 0x47,
            0x08, 0x7B, 0x1B, 0x18, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x79, 0x3C, 0x08, 0xF6, 0xE8, 0xED, 0x43, 0xD9, 0xAA, 0xCE, 0x70, 0x5E,
            0x86, 0x8D, 0x23, 0xDF, 0x19, 0xB9, 0x07, 0x51, 0x97, 0x56, 0x1E, 0xCB,
            0x1A, 0xA3, 0xEF, 0x70, 0x7A, 0x7A, 0xCF, 0x18, 0xA7, 0xD5, 0x29, 0xFE,
            0x21, 0x9D, 0x55, 0xE7, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D,
            0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D,
            0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25, 0x25,
            0x25, 0x25, 0x25, 0x25, 0x05, 0xC6, 0x08, 0x7C, 0xF7, 0x82, 0xDB, 0xA3,
            0x9E, 0x21, 0xBA, 0xFA, 0x8F, 0x31, 0xB3, 0x24, 0xBF, 0x58, 0x00, 0x16,
            0x4B, 0xBC, 0x3D, 0xDE, 0x0D, 0x15, 0xD6, 0x9D, 0xB7, 0x65, 0x46, 0xF4,
            0x49, 0x1C, 0xA3, 0x4F, 0xEF, 0x12, 0xF9, 0x59, 0xEC, 0x90, 0x0F, 0x00,
            0x5F, 0x36, 0xDD, 0x38, 0x90, 0x40, 0x76, 0x1E, 0xF2, 0xB8, 0x56, 0xD6
        },
        new byte[] {},// TODO: Add session key
        new byte[]
        {
            0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD,
            0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD,
            0xDD, 0xDD, 0xDD, 0xDD
        },
        new byte[CommonConstants.PublicKeyLengthFamilyZero] {
            0x84, 0x56, 0xA2, 0x69, 0x96, 0x12, 0x22, 0x16, 0xC9, 0x21, 0xC5, 0x71,
            0xFF, 0x11, 0xE0, 0xBE, 0xFA, 0xFD, 0xB1, 0xD7, 0x0B, 0x5D, 0x4B, 0xC8,
            0x39, 0x0F, 0x5B, 0x0C, 0xC2, 0x73, 0xEC, 0x14, 0x2A, 0x03, 0xF2, 0xA0,
            0x4E, 0x6F, 0x15, 0x93
        }
    )]
    [Experimental("familyZero")]
    public void AuthenticateFamilyZeroTest(
        byte[] expectedEncryptedBlobData,
        byte[] expectedSessionKey,
        byte[] challenge,
        byte[] publicKey)
    {
        var origSeq = SpanExtensions.StaticFillSequence;
        
        // Key1, Transform6 (2x), IV, Key2
        SpanExtensions.StaticFillSequence = [0x35, 0x2D, 0x2D, 0x25, 0x35];
        
        var blobData = new byte[CommonConstants.EncryptedBlobLengthFamilyZero];
        
        LegacyAuthenticationScheme.AuthenticateFamilyZero(
            blobData, 
            Span<byte>.Empty,
            challenge.AsSpan(),
            publicKey.AsSpan()
        );
        
        Assert.That(blobData, Is.EqualTo(expectedEncryptedBlobData));
        // TODO: Assert session key

        SpanExtensions.StaticFillSequence = origSeq;
    }
}