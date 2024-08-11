using System.Security.Cryptography;
using HarpoS7.Auth;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Tests.Auth;

public class LegitimateSchemeTests
{
    [SetUp]
    public void SetupPrng()
    {
        SpanExtensions.StaticFillSequence = [0x33, 0xCC];
    }
    
    [Test]
    [TestCase(
        // TODO: Add test case for random challenge
        new byte[LegitimateScheme.ChallengeLength] {
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 
            0x66, 0x66, 0x66, 0x66
        }, 
        new byte[Constants.PublicKeyLength] {
            0x47, 0x00, 0xDB, 0x8F, 0xA2, 0x5D, 0x79, 0x1C,
            0x2A, 0x77, 0xEE, 0xC9, 0x79, 0x5D, 0x66, 0xE3,
            0xB5, 0xF2, 0xBA, 0x9A, 0x59, 0x50, 0x8A, 0xDD,
            0x51, 0x0C, 0xA9, 0xFE, 0x87, 0x62, 0xAA, 0x08,
            0x1D, 0xFF, 0x80, 0xEA, 0x8F, 0x73, 0x0A, 0xD4,
            0xCA, 0xA0, 0xBC, 0xA7, 0xBA, 0x92, 0x89, 0x2C,
            0x69, 0x19, 0x84, 0x33, 0x8E, 0xEC, 0x20, 0x47,
            0x68, 0x1D, 0x95, 0x8D, 0xC5, 0xC5, 0x08, 0x6A
        }, 
        new byte[Constants.SessionKeyLength] {
            0x37, 0xA9, 0x7B, 0xEB, 0xD4, 0x8C, 0x8D, 0x2C,
            0x67, 0x83, 0x8B, 0x85, 0x8C, 0x4A, 0xAB, 0x4D,
            0xEF, 0xA6, 0x89, 0x7C, 0xD3, 0x38, 0xF7, 0x0B
        }, new byte[SHA1.HashSizeInBytes] {
            0xEB, 0x54, 0xAF, 0x6D, 0x27, 0xB8, 0x9F, 0x75,
            0xF1, 0x62, 0x44, 0xB7, 0x92, 0x95, 0xC4, 0x0A,
            0xBC, 0x30, 0x6E, 0x39
        }, new byte[LegitimateScheme.OutputBlobDataLength] {
            0xEF, 0xBE, 0xAD, 0xDE, 0xA0, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xCA, 0x4A, 0xAA, 0x9C,
            0xAC, 0x54, 0x76, 0xB0, 0x10, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x7C, 0x5F, 0xE4, 0x0F,
            0xD8, 0xB8, 0xF7, 0xCA, 0x01, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00,
            0x51, 0xA7, 0x58, 0x08, 0x33, 0x89, 0x8E, 0xA1,
            0xB1, 0x83, 0xCB, 0xD7, 0x35, 0x0A, 0x40, 0x99,
            0x07, 0x8C, 0x6E, 0xF1, 0xC1, 0xE1, 0x8E, 0x97,
            0x0C, 0xD7, 0x68, 0x30, 0x35, 0xF2, 0x5E, 0x7D,
            0x01, 0x10, 0x52, 0x27, 0x12, 0xB0, 0xB5, 0xA7,
            0xCF, 0xF0, 0x81, 0x68, 0x54, 0x86, 0x98, 0x4A,
            0x94, 0xE6, 0x83, 0x1E, 0xDA, 0xC4, 0x6E, 0x73,
            0x60, 0xFA, 0x9D, 0x83, 0x4A, 0x7A, 0x81, 0xA1,
            0xFE, 0xCE, 0xEC, 0x9B, 0x9C, 0xF9, 0x81, 0x88,
            0x1E, 0xF8, 0xC4, 0xB6, 0x71, 0x79, 0x6D, 0xE7,
            0x1E, 0xBC, 0xA3, 0x4D, 0x1E, 0x2B, 0xC0, 0x3E,
            0x47, 0x4D, 0x6A, 0x82, 0x11, 0x7D, 0xFA, 0x56,
            0xEF, 0xBE, 0xAD, 0xDE, 0x00, 0x00, 0x00, 0x00,
            0x40, 0x00, 0x00, 0x00, 0xCC, 0xCC, 0xCC, 0xCC,
            0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC,
            0xCC, 0xCC, 0xCC, 0xCC, 0x07, 0x62, 0xBE, 0xE8,
            0x3E, 0xBE, 0xAF, 0x57, 0x04, 0xDB, 0x63, 0x88,
            0xC9, 0x60, 0xEA, 0xEC, 0xE0, 0x90, 0xB8, 0xC9,
            0xB4, 0xB5, 0xAC, 0x0F, 0xFC, 0x55, 0xFC, 0x25,
            0x91, 0x9C, 0xA1, 0xBE, 0xB9, 0x7E, 0x95, 0x1D,
            0x4B, 0xDA, 0xED, 0x99, 0x0F, 0x0E, 0x9A, 0x94,
            0x44, 0x2D, 0x1F, 0x41, 0xEF, 0xBE, 0xAD, 0xDE,
            0x01, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00,
            0x40, 0x70, 0xA5, 0xEE, 0x93, 0xA2, 0x4E, 0xAB,
            0x83, 0x62, 0xD8, 0xBA, 0x31, 0x7B, 0x25, 0x3E,
            0x4C, 0xD5, 0x20, 0x6B, 0xA3, 0x4C, 0x8E, 0x03,
            0xEF, 0xBE, 0xAD, 0xDE, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
        })]
    public void SolveLegitimateChallengeHashTest( 
        byte[] challenge, 
        byte[] publicKey,
        byte[] sessionKey,
        byte[] passwordHash,
        byte[] expected)
    {
        var destination = new byte[LegitimateScheme.OutputBlobDataLength];
        LegitimateScheme.SolveLegitimateChallenge(
            destination, 
            challenge, 
            publicKey, 
            sessionKey, 
            passwordHash);
        
        Assert.That(destination, Is.EqualTo(expected));
    }
    
        [Test]
    [TestCase(
        // TODO: Add test case for random challenge
        new byte[LegitimateScheme.ChallengeLength] {
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 
            0x66, 0x66, 0x66, 0x66
        }, 
        new byte[Constants.PublicKeyLength] {
            0x47, 0x00, 0xDB, 0x8F, 0xA2, 0x5D, 0x79, 0x1C,
            0x2A, 0x77, 0xEE, 0xC9, 0x79, 0x5D, 0x66, 0xE3,
            0xB5, 0xF2, 0xBA, 0x9A, 0x59, 0x50, 0x8A, 0xDD,
            0x51, 0x0C, 0xA9, 0xFE, 0x87, 0x62, 0xAA, 0x08,
            0x1D, 0xFF, 0x80, 0xEA, 0x8F, 0x73, 0x0A, 0xD4,
            0xCA, 0xA0, 0xBC, 0xA7, 0xBA, 0x92, 0x89, 0x2C,
            0x69, 0x19, 0x84, 0x33, 0x8E, 0xEC, 0x20, 0x47,
            0x68, 0x1D, 0x95, 0x8D, 0xC5, 0xC5, 0x08, 0x6A
        }, 
        new byte[Constants.SessionKeyLength] {
            0x37, 0xA9, 0x7B, 0xEB, 0xD4, 0x8C, 0x8D, 0x2C,
            0x67, 0x83, 0x8B, 0x85, 0x8C, 0x4A, 0xAB, 0x4D,
            0xEF, 0xA6, 0x89, 0x7C, 0xD3, 0x38, 0xF7, 0x0B
        }, 
        "Access123$",
        new byte[LegitimateScheme.OutputBlobDataLength] {
            0xEF, 0xBE, 0xAD, 0xDE, 0xA0, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xCA, 0x4A, 0xAA, 0x9C,
            0xAC, 0x54, 0x76, 0xB0, 0x10, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x7C, 0x5F, 0xE4, 0x0F,
            0xD8, 0xB8, 0xF7, 0xCA, 0x01, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00,
            0x51, 0xA7, 0x58, 0x08, 0x33, 0x89, 0x8E, 0xA1,
            0xB1, 0x83, 0xCB, 0xD7, 0x35, 0x0A, 0x40, 0x99,
            0x07, 0x8C, 0x6E, 0xF1, 0xC1, 0xE1, 0x8E, 0x97,
            0x0C, 0xD7, 0x68, 0x30, 0x35, 0xF2, 0x5E, 0x7D,
            0x01, 0x10, 0x52, 0x27, 0x12, 0xB0, 0xB5, 0xA7,
            0xCF, 0xF0, 0x81, 0x68, 0x54, 0x86, 0x98, 0x4A,
            0x94, 0xE6, 0x83, 0x1E, 0xDA, 0xC4, 0x6E, 0x73,
            0x60, 0xFA, 0x9D, 0x83, 0x4A, 0x7A, 0x81, 0xA1,
            0xFE, 0xCE, 0xEC, 0x9B, 0x9C, 0xF9, 0x81, 0x88,
            0x1E, 0xF8, 0xC4, 0xB6, 0x71, 0x79, 0x6D, 0xE7,
            0x1E, 0xBC, 0xA3, 0x4D, 0x1E, 0x2B, 0xC0, 0x3E,
            0x47, 0x4D, 0x6A, 0x82, 0x11, 0x7D, 0xFA, 0x56,
            0xEF, 0xBE, 0xAD, 0xDE, 0x00, 0x00, 0x00, 0x00,
            0x40, 0x00, 0x00, 0x00, 0xCC, 0xCC, 0xCC, 0xCC,
            0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC,
            0xCC, 0xCC, 0xCC, 0xCC, 0x07, 0x62, 0xBE, 0xE8,
            0x3E, 0xBE, 0xAF, 0x57, 0x04, 0xDB, 0x63, 0x88,
            0xC9, 0x60, 0xEA, 0xEC, 0xE0, 0x90, 0xB8, 0xC9,
            0xB4, 0xB5, 0xAC, 0x0F, 0xFC, 0x55, 0xFC, 0x25,
            0x91, 0x9C, 0xA1, 0xBE, 0xB9, 0x7E, 0x95, 0x1D,
            0x4B, 0xDA, 0xED, 0x99, 0x0F, 0x0E, 0x9A, 0x94,
            0x44, 0x2D, 0x1F, 0x41, 0xEF, 0xBE, 0xAD, 0xDE,
            0x01, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00,
            0x40, 0x70, 0xA5, 0xEE, 0x93, 0xA2, 0x4E, 0xAB,
            0x83, 0x62, 0xD8, 0xBA, 0x31, 0x7B, 0x25, 0x3E,
            0x4C, 0xD5, 0x20, 0x6B, 0xA3, 0x4C, 0x8E, 0x03,
            0xEF, 0xBE, 0xAD, 0xDE, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
        })]
    public void SolveLegitimateChallengePasswordStringTest( 
        byte[] challenge, 
        byte[] publicKey,
        byte[] sessionKey,
        string password,
        byte[] expected)
    {
        var destination = new byte[LegitimateScheme.OutputBlobDataLength];
        LegitimateScheme.SolveLegitimateChallenge(
            destination, 
            challenge, 
            publicKey, 
            sessionKey, 
            password);
        
        Assert.That(destination, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(
        new byte[Constants.PublicKeyLength] {
            0x47, 0x00, 0xDB, 0x8F, 0xA2, 0x5D, 0x79, 0x1C,
            0x2A, 0x77, 0xEE, 0xC9, 0x79, 0x5D, 0x66, 0xE3,
            0xB5, 0xF2, 0xBA, 0x9A, 0x59, 0x50, 0x8A, 0xDD,
            0x51, 0x0C, 0xA9, 0xFE, 0x87, 0x62, 0xAA, 0x08,
            0x1D, 0xFF, 0x80, 0xEA, 0x8F, 0x73, 0x0A, 0xD4,
            0xCA, 0xA0, 0xBC, 0xA7, 0xBA, 0x92, 0x89, 0x2C,
            0x69, 0x19, 0x84, 0x33, 0x8E, 0xEC, 0x20, 0x47,
            0x68, 0x1D, 0x95, 0x8D, 0xC5, 0xC5, 0x08, 0x6A
        }, 
        new byte[Constants.SymmetricKeyLength] {
            0xA4, 0x3A, 0x36, 0x8E, 0xBD, 0xD2, 0xD2, 0x9A,
            0x28, 0x1C, 0xBF, 0xC8, 0x22, 0xEB, 0xD8, 0x4B,
            0x37, 0x8E, 0xF4, 0x5D, 0xC5, 0xE5, 0x27, 0x8E           
        }, 
        0xA0,
        CommonConstants.EncryptedSeedLength,
        new byte[LegitimateScheme.BeefSeedMetadataLength] {
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
        byte[] symmetricKey, 
        int fragmentLength, 
        int seedLength, 
        byte[] expected)
    {
        var destination = new byte[LegitimateScheme.BeefSeedMetadataLength];
        LegitimateScheme.WriteSeedBeefMetadata(
            destination, 
            publicKey, 
            symmetricKey, 
            fragmentLength, 
            seedLength
        );
        
        Assert.That(destination, Is.EqualTo(expected));
    }
    
    [Test]
    [TestCase(
        0x00, 
        0x40, 
        new byte[LegitimateScheme.BeefFragmentMetadataLength] {
            0xEF, 0xBE, 0xAD, 0xDE, 0x00, 0x00, 0x00, 0x00,
            0x40, 0x00, 0x00, 0x00
        })]
    [TestCase(
        0x01, 
        0x18, 
        new byte[LegitimateScheme.BeefFragmentMetadataLength] {
            0xEF, 0xBE, 0xAD, 0xDE, 0x01, 0x00, 0x00, 0x00,
            0x18, 0x00, 0x00, 0x00
        })]
    [TestCase(
        0x02, 
        0x00, 
        new byte[LegitimateScheme.BeefFragmentMetadataLength] {
            0xEF, 0xBE, 0xAD, 0xDE, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
        })]
    public void WriteFragmentBeefMetadataTest(int index, int length, byte[] expected)
    {
        var destination = new byte[LegitimateScheme.BeefFragmentMetadataLength];
        LegitimateScheme.WriteFragmentBeefMetadata(destination, index, length);
        
        Assert.That(destination, Is.EqualTo(expected));
    }
}