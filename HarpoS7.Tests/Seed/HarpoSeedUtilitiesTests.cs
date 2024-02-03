using System.Runtime.InteropServices;
using HarpoS7.Seed;

namespace HarpoS7.Tests.Seed;

public class HarpoSeedUtilitiesTests
{
    public static IEnumerable<TestCaseData> SeedFunction5TestData
        {
            get
            {
                yield return new TestCaseData(
                    new byte[64 + sizeof(ulong)],
                    new byte[32] {
                        0x54, 0x34, 0x42, 0x4D, 0x46, 0x55, 0xE0, 0xEF, 0x66, 0x85, 0x8B, 0x95,
                        0x58, 0xD8, 0xE3, 0x70, 0xF3, 0x3B, 0x12, 0x42, 0x4E, 0x17, 0xA3, 0x7E,
                        0x75, 0xCF, 0xC9, 0xEF, 0xAB, 0x46, 0x88, 0x1E
                    },
                    new byte[32] {
                        0x69, 0x6F, 0x49, 0xBC, 0x22, 0x9E, 0xE6, 0x27, 0x71, 0xC7, 0xF6, 0xDA,
                        0x91, 0xAF, 0x9C, 0x01, 0x42, 0x61, 0x2F, 0x99, 0x2B, 0x6D, 0x95, 0xC7,
                        0xD9, 0xCE, 0xA8, 0xBC, 0xE3, 0xB0, 0x20, 0x06
                    },
                    new byte[32] {
                        0x5E, 0xE9, 0x98, 0xA8, 0xEF, 0xF0, 0x83, 0x19, 0x3A, 0xAD, 0x75, 0xBF,
                        0x3E, 0xEA, 0xD7, 0xEE, 0x8E, 0x8B, 0x5C, 0xA3, 0x98, 0x10, 0x60, 0xD6,
                        0xC1, 0xBD, 0xE3, 0xFE, 0x17, 0xB9, 0x3F, 0x3E
                    },
                    new byte[72] {
                        0xFE, 0x02, 0xDC, 0x30, 0x06, 0x6C, 0x77, 0x59, 0x24, 0x5B, 0xFE, 0x58,
                        0x52, 0xC8, 0xB8, 0xF1, 0x52, 0x3D, 0x90, 0xED, 0x53, 0x84, 0xFC, 0xCE,
                        0x64, 0xD9, 0xA6, 0xB4, 0xE0, 0x24, 0xF1, 0x18, 0x25, 0xF3, 0x4B, 0x70,
                        0xD2, 0x87, 0xC2, 0xC3, 0x8A, 0xDA, 0x73, 0x1C, 0x0B, 0xA1, 0xCC, 0xD7,
                        0xEB, 0x69, 0xAE, 0x37, 0x00, 0xA5, 0x28, 0xA7, 0x1E, 0x0B, 0xD1, 0xD6,
                        0x82, 0xB0, 0xD0, 0xF6, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    });
            }
        }

        public static IEnumerable<TestCaseData> SeedFunction2TestData
        {
            get
            {
                var a3 = new byte[32].AsSpan();
                a3.Fill(0xDD);
                var a3Arr = a3.ToArray();

                yield return new TestCaseData(
                    new byte[72],
                    new byte[72] {
                        0x96, 0xC2, 0x98, 0xD8, 0x45, 0x39, 0xA1, 0xF4, 0xA0, 0x33, 0xEB, 0x2D,
                        0x81, 0x7D, 0x03, 0x77, 0xF2, 0x40, 0xA4, 0x63, 0xE5, 0xE6, 0xBC, 0xF8,
                        0x47, 0x42, 0x2C, 0xE1, 0xF2, 0xD1, 0x17, 0x6B, 0xF5, 0x51, 0xBF, 0x37,
                        0x68, 0x40, 0xB6, 0xCB, 0xCE, 0x5E, 0x31, 0x6B, 0x57, 0x33, 0xCE, 0x2B,
                        0x16, 0x9E, 0x0F, 0x7C, 0x4A, 0xEB, 0xE7, 0x8E, 0x9B, 0x7F, 0x1A, 0xFE,
                        0xE2, 0x42, 0xE3, 0x4F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    },
                    a3Arr,
                    4,
                    new byte[72] {
                        0xFE, 0x02, 0xDC, 0x30, 0x06, 0x6C, 0x77, 0x59, 0x24, 0x5B, 0xFE, 0x58,
                        0x52, 0xC8, 0xB8, 0xF1, 0x52, 0x3D, 0x90, 0xED, 0x53, 0x84, 0xFC, 0xCE,
                        0x64, 0xD9, 0xA6, 0xB4, 0xE0, 0x24, 0xF1, 0x18, 0x25, 0xF3, 0x4B, 0x70,
                        0xD2, 0x87, 0xC2, 0xC3, 0x8A, 0xDA, 0x73, 0x1C, 0x0B, 0xA1, 0xCC, 0xD7,
                        0xEB, 0x69, 0xAE, 0x37, 0x00, 0xA5, 0x28, 0xA7, 0x1E, 0x0B, 0xD1, 0xD6,
                        0x82, 0xB0, 0xD0, 0xF6, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    });
                yield return new TestCaseData(
                    new byte[72],
                    new byte[72] {
                        0xB0, 0xA6, 0x32, 0x65, 0x28, 0xF3, 0x94, 0x73, 0x7A, 0x87, 0x97, 0x89,
                        0xBA, 0xE6, 0xC9, 0x26, 0xE4, 0x31, 0x53, 0x24, 0xD7, 0xB5, 0x16, 0xDD,
                        0xAA, 0x3E, 0xF0, 0xDD, 0x99, 0xD7, 0xA6, 0xEC, 0xE9, 0x39, 0x7F, 0x69,
                        0x71, 0xD2, 0x8E, 0x90, 0x03, 0xC9, 0xEB, 0x0F, 0xC1, 0x54, 0xC3, 0xD6,
                        0x3B, 0xC4, 0xD5, 0xA4, 0xFB, 0x83, 0x24, 0x43, 0x23, 0x52, 0x08, 0x18,
                        0x98, 0x22, 0xE4, 0x53, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    },
                    a3Arr,
                    4,
                    new byte[72] {
                        0xB3, 0x42, 0x0D, 0x0C, 0x62, 0x42, 0xB1, 0x50, 0xD6, 0x86, 0x2A, 0x4D,
                        0x61, 0x55, 0x9E, 0x78, 0xA0, 0x0D, 0xA5, 0xDC, 0x7B, 0x68, 0x55, 0x1A,
                        0xD8, 0x6D, 0xF0, 0x07, 0xAB, 0xA5, 0xBB, 0xD9, 0x94, 0x83, 0x77, 0xE4,
                        0x44, 0x8F, 0xEF, 0xF6, 0x9F, 0x28, 0x8A, 0x01, 0x4C, 0x08, 0x32, 0xB2,
                        0x41, 0xED, 0x17, 0xB1, 0x7C, 0x7E, 0xC6, 0x9C, 0xD7, 0xD9, 0xEF, 0xBF,
                        0xFA, 0x69, 0x23, 0x91, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    });
            }
        }

        // hell yeah
        [Test]
        public void GenerateEncryptedSeedTest()
        {
            ReadOnlySpan<byte> publicKey = new byte[64]
            {
                0xEC, 0xA6, 0xD7, 0x99, 0xDD, 0xF0, 0x3E, 0xAA, 0xDD, 0x16, 0xB5, 0xD7,
                0x24, 0x53, 0x31, 0xE4, 0x26, 0xC9, 0xE6, 0xBA, 0x89, 0x97, 0x87, 0x7A,
                0x73, 0x94, 0xF3, 0x28, 0x65, 0x32, 0xA6, 0xB0, 0x53, 0xE4, 0x22, 0x98,
                0x18, 0x08, 0x52, 0x23, 0x43, 0x24, 0x83, 0xFB, 0xA4, 0xD5, 0xC4, 0x3B,
                0xD6, 0xC3, 0x54, 0xC1, 0x0F, 0xEB, 0xC9, 0x03, 0x90, 0x8E, 0xD2, 0x71,
                0x69, 0x7F, 0x39, 0xE9
            };
            ReadOnlySpan<byte> seedKey = new byte[16]
            {
                0x4E, 0x00, 0x10, 0x16, 0xDB, 0x62, 0x5D, 0xCC, 0xE9, 0x10, 0x5B, 0xDC,
                0xD8, 0xA1, 0xB4, 0x2C
            };
            Span<byte> destination = new byte[0x60];

            HarpoSeedUtilities.GenerateEncryptedSeed(destination, publicKey, seedKey);

            ReadOnlySpan<byte> expectedSeed = new byte[0x60] {
                0x51, 0xA7, 0x58, 0x08, 0x33, 0x89, 0x8E, 0xA1, 0xB1, 0x83, 0xCB, 0xD7,
                0x35, 0x0A, 0x40, 0x99, 0x07, 0x8C, 0x6E, 0xF1, 0xC1, 0xE1, 0x8E, 0x97,
                0x0C, 0xD7, 0x68, 0x30, 0x35, 0xF2, 0x5E, 0x7D, 0x01, 0x10, 0x52, 0x27,
                0x12, 0xB0, 0xB5, 0xA7, 0xCF, 0xF0, 0x81, 0x68, 0x54, 0x86, 0x98, 0x4A,
                0x94, 0xE6, 0x83, 0x1E, 0xDA, 0xC4, 0x6E, 0x73, 0x60, 0xFA, 0x9D, 0x83,
                0x4A, 0x7A, 0x81, 0xA1, 0x43, 0x6D, 0x6F, 0xE9, 0xAE, 0x24, 0x35, 0xC7,
                0xDE, 0x4A, 0x82, 0x34, 0xD8, 0x10, 0xF5, 0xAA, 0x2E, 0x5F, 0x61, 0x2C,
                0x49, 0xD5, 0x05, 0x59, 0xF8, 0xDA, 0x65, 0x02, 0x57, 0x2B, 0x3A, 0xDD
            };
            Assert.That(destination.SequenceEqual(expectedSeed));
        }

        [Test]
        public void ZeroCheck32ZeroTest()
        {
            Span<byte> data = new byte[8 * sizeof(uint)];

            // explicitly set all uints to zero
            data.Fill(0x00);

            var result = HarpoSeedUtilities.ZeroCheck32(data);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ZeroCheck32NotZeroTest()
        {
            Span<byte> data = new byte[8 * sizeof(uint)];

            // explicitly set all uints to zero
            data.Fill(0x00);

            // set some bytes to not zero
            data.Slice(15, 13).Fill(0xFD);

            var result = HarpoSeedUtilities.ZeroCheck32(data);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void PubKeyOp5Test()
        {
            Span<byte> a1 = new byte[64];
            ulong a2 = 0x7394F3286532A6B0;
            Span<byte> a3 = new byte[] {
                0x7A, 0x87, 0x97, 0x89, 0xBA, 0xE6, 0xC9, 0x26, 0xE4, 0x31, 0x53, 0x24,
                0xD7, 0xB5, 0x16, 0xDD, 0xAA, 0x3E, 0xF0, 0xDD, 0x99, 0xD7, 0xA6, 0xEC,
                0xE9, 0x39, 0x7F, 0x69, 0x71, 0xD2, 0x8E, 0x90, 0x03, 0xC9, 0xEB, 0x0F,
                0xC1, 0x54, 0xC3, 0xD6, 0x3B, 0xC4, 0xD5, 0xA4, 0xFB, 0x83, 0x24, 0x43,
                0x23, 0x52, 0x08, 0x18, 0x98, 0x22, 0xE4, 0x53, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00
            };

            ulong a4 = 0UL;
            int a5 = 3;

            var result = HarpoSeedUtilities.PubKeyOp5(
                MemoryMarshal.Cast<byte, ulong>(a1),
                a2,
                MemoryMarshal.Cast<byte, ulong>(a3),
                a4,
                a5);

            Assert.That(result, Is.EqualTo(0x6AD8A41679EC9E7DUL));

            ReadOnlySpan<byte> expectedA1 = new byte[] {
                0xE0, 0x3F, 0xDA, 0x71, 0x92, 0x36, 0xF1, 0xB4, 0xAE, 0x34, 0x9F, 0x92,
                0x3C, 0xEC, 0x8E, 0x19, 0x9D, 0x05, 0x41, 0xE4, 0xB7, 0x20, 0x3E, 0x68
            };

            Assert.That(expectedA1.SequenceEqual(a1[..expectedA1.Length]));
        }

        [Test]
        public void PubKeyOp7Test()
        {
            Span<byte> a1 = new byte[32];
            ReadOnlySpan<byte> a2 = new byte[] {
                0x00, 0xB9, 0x48, 0x69, 0x8C, 0x38, 0xC7, 0xCB, 0x90, 0xBA, 0x4A, 0x3C,
                0x45, 0x96, 0x11, 0x9E, 0x81, 0x4F, 0xDC, 0xD2, 0x72, 0x76, 0x45, 0xAA,
                0xDD, 0xD3, 0x1C, 0x8B, 0x64, 0x1F, 0x0B, 0x9B, 0xD8, 0xEE, 0x0F, 0xAF,
                0xA1, 0xBA, 0x73, 0x9F, 0xBA, 0xD9, 0xC2, 0xDE, 0x8B, 0x1A, 0xEF, 0x4D,
                0xBA, 0x2F, 0x00, 0x7A, 0xF9, 0x2D, 0x0F, 0xE0, 0x60, 0x96, 0x52, 0x02,
                0x40, 0x0A, 0xC4, 0xDA
            };

            HarpoSeedUtilities.PubKeyOp7(a1, a2, 0x0F, 0x0E, 0x0D, 0x0C, 0x0B, 0x00, 0x00, 0x00);

            ReadOnlySpan<byte> expected = new byte[32] {
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x8B, 0x1A, 0xEF, 0x4D, 0xBA, 0x2F, 0x00, 0x7A, 0xF9, 0x2D, 0x0F, 0xE0,
                0x60, 0x96, 0x52, 0x02, 0x40, 0x0A, 0xC4, 0xDA
            };

            Assert.That(expected.SequenceEqual(a1));
        }

        [Test]
        public void PubKeyOp4Test()
        {
            Span<byte> destination = new byte[32];
            ReadOnlySpan<byte> a2 = new byte[] {
                0xB0, 0xA6, 0x32, 0x65, 0x28, 0xF3, 0x94, 0x73, 0x7A, 0x87, 0x97, 0x89,
                0xBA, 0xE6, 0xC9, 0x26, 0xE4, 0x31, 0x53, 0x24, 0xD7, 0xB5, 0x16, 0xDD,
                0xAA, 0x3E, 0xF0, 0xDD, 0x99, 0xD7, 0xA6, 0xEC, 0xE9, 0x39, 0x7F, 0x69,
                0x71, 0xD2, 0x8E, 0x90, 0x03, 0xC9, 0xEB, 0x0F, 0xC1, 0x54, 0xC3, 0xD6,
                0x3B, 0xC4, 0xD5, 0xA4, 0xFB, 0x83, 0x24, 0x43, 0x23, 0x52, 0x08, 0x18,
                0x98, 0x22, 0xE4, 0x53
            };

            HarpoSeedUtilities.PubKeyOp4(destination, a2);

            ReadOnlySpan<byte> destinationExpected = new byte[] {
                0xDC, 0x53, 0x7B, 0x0D, 0x94, 0xCE, 0xD7, 0x12, 0x3C, 0xE0, 0xD6, 0xAB,
                0x0D, 0xA5, 0xB7, 0xE4, 0xEC, 0x0C, 0x17, 0x0B, 0x21, 0x15, 0x1B, 0x1D,
                0xFE, 0x2F, 0x28, 0xD9, 0x06, 0xDB, 0xA5, 0x53
            };
            Assert.That(destinationExpected.SequenceEqual(destination));
        }

        [Test]
        public void PubKeyOp4DestinationNotZeroTest()
        {
            Span<byte> destination = new byte[32] {
                0x4F, 0x05, 0x4F, 0x5C, 0xE3, 0x27, 0xF4, 0x08, 0x04, 0x45, 0x7C, 0xC6,
                0xC0, 0xAE, 0xEB, 0x97, 0x2D, 0x14, 0xB1, 0x5D, 0x65, 0x23, 0x54, 0xE8,
                0x68, 0x1D, 0xA4, 0xF2, 0x04, 0xFD, 0x6B, 0x1B
            };

            ReadOnlySpan<byte> a2 = new byte[64] {
                0x4F, 0x05, 0x4F, 0x5C, 0xE3, 0x27, 0xF4, 0x08, 0x04, 0x45, 0x7C, 0xC6,
                0xC0, 0xAE, 0xEB, 0x97, 0x2D, 0x14, 0xB1, 0x5D, 0x65, 0x23, 0x54, 0xE8,
                0x68, 0x1D, 0xA4, 0xF2, 0x04, 0xFD, 0x6B, 0x1B, 0xF9, 0x72, 0xAC, 0x34,
                0x7F, 0x24, 0xAF, 0x29, 0x89, 0xC5, 0xB7, 0x9F, 0x8B, 0x6B, 0xB3, 0x28,
                0x7D, 0xD1, 0x35, 0x4C, 0xCB, 0x09, 0x46, 0x24, 0x21, 0xDF, 0x74, 0xE7,
                0x63, 0xAE, 0xAF, 0xE6
            };

            HarpoSeedUtilities.PubKeyOp4(destination, a2);

            ReadOnlySpan<byte> destinationExpected = new byte[32] {
                0xF1, 0x20, 0x0A, 0x57, 0x10, 0xC9, 0x0E, 0xD2, 0x86, 0x21, 0xE9, 0xA7,
                0xE8, 0x4B, 0xB8, 0xE0, 0x2A, 0xB5, 0xB2, 0xC5, 0x94, 0x14, 0xF1, 0x09,
                0xBC, 0xF0, 0x2A, 0x99, 0x04, 0xC7, 0xB3, 0x88
            };

            Assert.That(destinationExpected.SequenceEqual(destination));
        }

        [Test]
        public void PubKeyOp8Test()
        {
            Span<byte> a1 = new byte[] {
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x8B, 0x1A, 0xEF, 0x4D, 0xBA, 0x2F, 0x00, 0x7A, 0xF9, 0x2D, 0x0F, 0xE0,
                0x60, 0x96, 0x52, 0x02, 0x40, 0x0A, 0xC4, 0xDA
            };
            ReadOnlySpan<byte> a3 = new byte[] {
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xBA, 0x2F, 0x00, 0x7A, 0xF9, 0x2D, 0x0F, 0xE0, 0x60, 0x96, 0x52, 0x02,
                0x40, 0x0A, 0xC4, 0xDA, 0x00, 0x00, 0x00, 0x00
            };

            var result = HarpoSeedUtilities.PubKeyOp8(a1, a1, a3);

            Assert.That(result, Is.EqualTo(0UL));

            ReadOnlySpan<byte> a1Expected = new byte[] {
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x45, 0x4A, 0xEF, 0xC7, 0xB3, 0x5D, 0x0F, 0x5A, 0x5A, 0xC4, 0x61, 0xE2,
                0xA0, 0xA0, 0x16, 0xDD, 0x40, 0x0A, 0xC4, 0xDA
            };
            Assert.That(a1Expected.SequenceEqual(a1));
        }

        [Test]
        public void PubKeyOp9TestArgument4Zero()
        {
            Span<byte> a1 = new byte[] {
                0x79, 0x62, 0xCC, 0xB7, 0xE8, 0xCC, 0xFD, 0x49, 0xD7, 0xAE, 0xFC, 0x68,
                0xC9, 0x58, 0xFF, 0x0D, 0x4A, 0xA1, 0x4D, 0x89, 0x67, 0x09, 0xCD, 0x49,
                0x79, 0xD9, 0xAB, 0x27, 0xFF, 0x2C, 0x67, 0xDA
            };
            ReadOnlySpan<byte> a3 = new byte[] {
                0x8B, 0x1A, 0xEF, 0x4D, 0xBA, 0x2F, 0x00, 0x7A, 0xF9, 0x2D, 0x0F, 0xE0,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0xD8, 0xEE, 0x0F, 0xAF, 0xBA, 0xD9, 0xC2, 0xDE
            };

            var result = HarpoSeedUtilities.PubKeyOp9(a1, a1, a3, 0);

            Assert.That(result, Is.EqualTo(1UL));

            ReadOnlySpan<byte> a1Expected = new byte[] {
                0xEE, 0x47, 0xDD, 0x69, 0x2E, 0x9D, 0xFD, 0xCF, 0xDD, 0x80, 0xED, 0x88,
                0xC8, 0x58, 0xFF, 0x0D, 0x4A, 0xA1, 0x4D, 0x89, 0x67, 0x09, 0xCD, 0x49,
                0xA1, 0xEA, 0x9B, 0x78, 0x44, 0x53, 0xA4, 0xFB
            };

            Assert.That(a1Expected.SequenceEqual(a1));
        }

        [Test]
        public void SeedMaskSub2Test()
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEA, 0xA3, 0x7E, 0x6F, 0xD0, 0x80, 0x6C, 0x97, 0x9D, 0xBD, 0x62, 0xD6,
                0xAE, 0x66, 0x9C, 0x57, 0x2C, 0x3C, 0x1F, 0xF8, 0x94, 0xD6, 0xCF, 0x1D,
                0x37, 0xFF, 0x34, 0xFC, 0xC5, 0x85, 0xC6, 0x9F, 0xF0, 0xCB, 0x66, 0xD3,
                0x3A, 0xC7, 0xAF, 0x85, 0xA9, 0xF4, 0x13, 0xEC, 0xF0, 0xDD, 0xA6, 0x8B,
                0x57, 0x20, 0x58, 0x4D, 0x16, 0x66, 0xA9, 0x75, 0xE3, 0x4C, 0xA1, 0xDC,
                0xEC, 0x94, 0x35, 0x10, 0xEF, 0x66, 0xB7, 0xA6, 0x8A, 0x37, 0x5C, 0xBC,
                0x28, 0x48, 0x0E, 0x9C, 0x03, 0xA2, 0xB1, 0x3B, 0x37, 0xCA, 0x1B, 0x3C,
                0x34, 0x45, 0xCA, 0xEC, 0xAE, 0x41, 0x19, 0x1F, 0xF0, 0x53, 0xFC, 0x1B,
                0x19, 0x7F, 0xD6, 0x84, 0xD8, 0xCA, 0x55, 0x00, 0xA2, 0x9B, 0xD2, 0xBA,
                0x91, 0x32, 0x6D, 0x67, 0xB0, 0x21, 0x6D, 0x1C, 0xBC, 0x34, 0x03, 0x03,
                0x64, 0xE5, 0x7D, 0x53, 0x9B, 0x70, 0xED, 0x31
            };

            var result = HarpoSeedUtilities.SeedMaskSub2(data, SeedConsts.Mask.Span, 4);

            Assert.That(result, Is.EqualTo(0xFFFFFFFF));
        }

        [Test]
        public void SeedMaskSub2LoopHitTest()
        {
            Span<byte> a1 = new byte[32] {
                0x8F, 0xDB, 0x64, 0x4D, 0x68, 0x5B, 0xE3, 0x02, 0x86, 0xF1, 0x19, 0xBE,
                0xE7, 0x40, 0xBD, 0xFF, 0x2D, 0xF7, 0x47, 0x56, 0x1C, 0xA1, 0x1E, 0x0D,
                0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };
            ReadOnlySpan<byte> a2 = new byte[32] {
                0xA5, 0x83, 0x93, 0x3A, 0xE6, 0xA0, 0x5F, 0xD7, 0x56, 0x70, 0x8C, 0x66,
                0x69, 0x6E, 0xB3, 0xF1, 0xDF, 0x61, 0x75, 0x4F, 0x27, 0x7B, 0x7D, 0x0C,
                0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };

            Assert.That(HarpoSeedUtilities.SeedMaskSub2(a1, a2, 4), Is.EqualTo(1U));
        }

        [Test]
        public void PublicKeyOp6Test()
        {
            Span<byte> destination = new byte[32];
            ReadOnlySpan<byte> a2 = new byte[] {
                0x00, 0xB9, 0x48, 0x69, 0x8C, 0x38, 0xC7, 0xCB, 0x90, 0xBA, 0x4A, 0x3C,
                0x45, 0x96, 0x11, 0x9E, 0x81, 0x4F, 0xDC, 0xD2, 0x72, 0x76, 0x45, 0xAA,
                0xDD, 0xD3, 0x1C, 0x8B, 0x64, 0x1F, 0x0B, 0x9B, 0xD8, 0xEE, 0x0F, 0xAF,
                0xA1, 0xBA, 0x73, 0x9F, 0xBA, 0xD9, 0xC2, 0xDE, 0x8B, 0x1A, 0xEF, 0x4D,
                0xBA, 0x2F, 0x00, 0x7A, 0xF9, 0x2D, 0x0F, 0xE0, 0x60, 0x96, 0x52, 0x02,
                0x40, 0x0A, 0xC4, 0xDA
            };

            HarpoSeedUtilities.PubKeyOp6(destination, a2);

            ReadOnlySpan<byte> expectedDestination = new byte[32] {
                0xDC, 0x53, 0x7B, 0x0D, 0x94, 0xCE, 0xD7, 0x12, 0x3C, 0xE0, 0xD6, 0xAB,
                0x0D, 0xA5, 0xB7, 0xE4, 0xEC, 0x0C, 0x17, 0x0B, 0x21, 0x15, 0x1B, 0x1D,
                0xFE, 0x2F, 0x28, 0xD9, 0x06, 0xDB, 0xA5, 0x53
            };
            Assert.IsTrue(expectedDestination.SequenceEqual(destination));
        }

        [Test]
        public void SeedMaskTest()
        {
            Span<byte> destination = new byte[32] {
                0xF0, 0xCB, 0x66, 0xD3, 0x3A, 0xC7, 0xAF, 0x85, 0xA9, 0xF4, 0x13, 0xEC,
                0xF0, 0xDD, 0xA6, 0x8B, 0x57, 0x20, 0x58, 0x4D, 0x16, 0x66, 0xA9, 0x75,
                0xE3, 0x4C, 0xA1, 0xDC, 0xEC, 0x94, 0x35, 0x10
            };
            ReadOnlySpan<byte> a2 = new byte[32] {
                0x0F, 0xC7, 0xD6, 0x91, 0x83, 0x84, 0x7D, 0x1E, 0xCF, 0xDD, 0x61, 0x4F,
                0x27, 0x42, 0x4B, 0x80, 0x43, 0xDE, 0xFC, 0xDC, 0x52, 0x7D, 0x0E, 0x57,
                0xAD, 0xB5, 0xD1, 0xAC, 0x59, 0x8F, 0x97, 0x9A
            };

            HarpoSeedUtilities.SeedMask(destination, a2);

            ReadOnlySpan<byte> expectedDestination = new byte[32] {
                0x0F, 0xC7, 0xD6, 0x91, 0x83, 0x84, 0x7D, 0x1E, 0xCF, 0xDD, 0x61, 0x4F,
                0x27, 0x42, 0x4B, 0x80, 0x43, 0xDE, 0xFC, 0xDC, 0x52, 0x7D, 0x0E, 0x57,
                0xAD, 0xB5, 0xD1, 0xAC, 0x59, 0x8F, 0x97, 0x9A
            };

            Assert.That(expectedDestination.SequenceEqual(destination));
        }

        [Test]
        public void SeedMaskOverlapTest()
        {
            Span<byte> destinationA2 = new byte[32] {
                0xEF, 0x66, 0xB7, 0xA6, 0x8A, 0x37, 0x5C, 0xBC, 0x28, 0x48, 0x0E, 0x9C,
                0x03, 0xA2, 0xB1, 0x3B, 0x37, 0xCA, 0x1B, 0x3C, 0x34, 0x45, 0xCA, 0xEC,
                0xAE, 0x41, 0x19, 0x1F, 0xF0, 0x53, 0xFC, 0x1B
            };

            HarpoSeedUtilities.SeedMask(destinationA2, destinationA2);

            ReadOnlySpan<byte> expectedDest = new byte[32] {
                0xEF, 0x66, 0xB7, 0xA6, 0x8A, 0x37, 0x5C, 0xBC, 0x28, 0x48, 0x0E, 0x9C,
                0x03, 0xA2, 0xB1, 0x3B, 0x37, 0xCA, 0x1B, 0x3C, 0x34, 0x45, 0xCA, 0xEC,
                0xAE, 0x41, 0x19, 0x1F, 0xF0, 0x53, 0xFC, 0x1B
            };
            Assert.That(expectedDest.SequenceEqual(destinationA2));
        }

        [Test]
        public void PubKeyOp12Test()
        {
            Span<byte> destination = new byte[32];

            ReadOnlySpan<byte> a2 = new byte[64] {
                0x45, 0xB6, 0x0F, 0x87, 0xF0, 0xB3, 0x74, 0xFB, 0x82, 0xD7, 0x4A, 0x90,
                0x89, 0x40, 0x2A, 0x26, 0xF9, 0xA7, 0x4D, 0x5E, 0xE6, 0x44, 0x52, 0x08,
                0xB5, 0xEE, 0xD1, 0x43, 0x62, 0x75, 0x7D, 0x57, 0xF0, 0xCB, 0x66, 0xD3,
                0x3A, 0xC7, 0xAF, 0x85, 0xA9, 0xF4, 0x13, 0xEC, 0xF0, 0xDD, 0xA6, 0x8B,
                0x57, 0x20, 0x58, 0x4D, 0x16, 0x66, 0xA9, 0x75, 0xE3, 0x4C, 0xA1, 0xDC,
                0xEC, 0x94, 0x35, 0x10
            };
            ReadOnlySpan<byte> a3 = new byte[64] {
                0x96, 0xC2, 0x98, 0xD8, 0x45, 0x39, 0xA1, 0xF4, 0xA0, 0x33, 0xEB, 0x2D,
                0x81, 0x7D, 0x03, 0x77, 0xF2, 0x40, 0xA4, 0x63, 0xE5, 0xE6, 0xBC, 0xF8,
                0x47, 0x42, 0x2C, 0xE1, 0xF2, 0xD1, 0x17, 0x6B, 0xF5, 0x51, 0xBF, 0x37,
                0x68, 0x40, 0xB6, 0xCB, 0xCE, 0x5E, 0x31, 0x6B, 0x57, 0x33, 0xCE, 0x2B,
                0x16, 0x9E, 0x0F, 0x7C, 0x4A, 0xEB, 0xE7, 0x8E, 0x9B, 0x7F, 0x1A, 0xFE,
                0xE2, 0x42, 0xE3, 0x4F
            };

            HarpoSeedUtilities.PubKeyOp12(destination, a2, a3);

            ReadOnlySpan<byte> expectedDestination = new byte[32] {
                0xEF, 0x66, 0xB7, 0xA6, 0x8A, 0x37, 0x5C, 0xBC, 0x28, 0x48, 0x0E, 0x9C,
                0x03, 0xA2, 0xB1, 0x3B, 0x37, 0xCA, 0x1B, 0x3C, 0x34, 0x45, 0xCA, 0xEC,
                0xAE, 0x41, 0x19, 0x1F, 0xF0, 0x53, 0xFC, 0x1B
            };
            Assert.That(expectedDestination.SequenceEqual(destination));
        }

        [Test]
        public void PubKeyOp16Test()
        {
            Span<byte> a1a2 = new byte[32] {
                0x97, 0xCA, 0x60, 0x40, 0xD4, 0xD1, 0x06, 0x1A, 0xEA, 0x68, 0x8D, 0xEB,
                0xDA, 0xD8, 0x37, 0x06, 0x1C, 0xF3, 0x51, 0x40, 0x39, 0x5F, 0xA6, 0x34,
                0x06, 0x15, 0xF1, 0xB8, 0xE4, 0xDC, 0x43, 0xED
            };
            ReadOnlySpan<byte> a3 = new byte[64] {
                0xB0, 0x2E, 0x29, 0x36, 0x92, 0x22, 0x94, 0x51, 0x23, 0x21, 0x32, 0xA3,
                0x2D, 0xED, 0xB4, 0xE5, 0x55, 0x1F, 0xD3, 0x89, 0xEE, 0x09, 0xCA, 0x5F,
                0x05, 0x07, 0x3B, 0xDD, 0x7F, 0xBE, 0x9E, 0x48, 0x5F, 0x78, 0x9E, 0xAD,
                0x18, 0x82, 0x33, 0x9C, 0x7A, 0x5C, 0xAE, 0x65, 0xA6, 0x1E, 0x21, 0xAE,
                0xBB, 0x5C, 0x5C, 0x88, 0x3E, 0xF1, 0x93, 0x8F, 0x1D, 0xC0, 0x2A, 0x83,
                0x42, 0x92, 0x9D, 0x86
            };

            HarpoSeedUtilities.PubKeyOp16(a1a2, a1a2, a3);

            ReadOnlySpan<byte> a1Expected = new byte[32] {
                0x48, 0xF9, 0x89, 0x76, 0x66, 0xF4, 0x9A, 0x6B, 0x0D, 0x8A, 0xBF, 0x8E,
                0x07, 0xC6, 0xEC, 0xEB, 0x71, 0x12, 0x25, 0xCA, 0x27, 0x69, 0x70, 0x94,
                0x0A, 0x1C, 0x2C, 0x96, 0x65, 0x9B, 0xE2, 0x35
            };
            Assert.That(a1Expected.SequenceEqual(a1a2));
        }

        [Test]
        public void PubKeyOp15Test()
        {
            Span<byte> a1a3 = new byte[32] {
                0x48, 0xF9, 0x89, 0x76, 0x66, 0xF4, 0x9A, 0x6B, 0x0D, 0x8A, 0xBF, 0x8E,
                0x07, 0xC6, 0xEC, 0xEB, 0x71, 0x12, 0x25, 0xCA, 0x27, 0x69, 0x70, 0x94,
                0x0A, 0x1C, 0x2C, 0x96, 0x65, 0x9B, 0xE2, 0x35
            };
            Span<byte> a2 = new byte[32] {
                0xE8, 0x65, 0x9D, 0xA2, 0x94, 0xCB, 0xA6, 0x7E, 0x8E, 0xFA, 0x5A, 0x99,
                0xA0, 0x2B, 0xAA, 0xF2, 0xCA, 0x1E, 0xA2, 0xB5, 0xE4, 0x5A, 0x9C, 0xEB,
                0xA8, 0x26, 0xDC, 0x5E, 0xA6, 0x1F, 0xAB, 0x44
            };

            HarpoSeedUtilities.PubKeyOp15(a1a3, a2, a1a3);

            ReadOnlySpan<byte> a1Expected = new byte[32] {
                0xA0, 0x6C, 0x13, 0x2C, 0x2E, 0xD7, 0x0B, 0x13, 0x81, 0x70, 0x9B, 0x0A,
                0x99, 0x65, 0xBD, 0x06, 0x59, 0x0C, 0x7D, 0xEB, 0xBC, 0xF1, 0x2B, 0x57,
                0x9E, 0x0A, 0xB0, 0xC8, 0x40, 0x84, 0xC8, 0x0E
            };
            Assert.That(a1Expected.SequenceEqual(a1a3));
        }

        [Test]
        public void SeedFunction3Test()
        {
            Span<byte> a1a4 = new byte[32] {
                0x27, 0xFA, 0x31, 0x4A, 0x9C, 0x48, 0xE5, 0x5F, 0x82, 0x00, 0x31, 0x74,
                0x85, 0xDB, 0x68, 0xB8, 0x71, 0xD0, 0x8E, 0xDE, 0xA3, 0x81, 0x76, 0x6A,
                0x4D, 0x72, 0x42, 0x60, 0x44, 0x8F, 0x93, 0x53
            };

            Span<byte> a2a5 = new byte[32] {
                0x80, 0x2D, 0x55, 0xBC, 0x51, 0x24, 0x22, 0x12, 0x79, 0x4F, 0xE8, 0xA3,
                0x84, 0x0C, 0xBB, 0x23, 0xE5, 0xB0, 0x34, 0xA8, 0xF5, 0xA8, 0x65, 0x93,
                0xCF, 0x4A, 0x6B, 0x99, 0xFC, 0xED, 0x09, 0x36
            };

            Span<byte> a3a6 = new byte[32] {
                0xC4, 0xC9, 0xDE, 0xB4, 0x17, 0xBF, 0x3D, 0xB9, 0x03, 0x4A, 0x5C, 0x4B,
                0xBA, 0xB0, 0x93, 0xA5, 0x4E, 0xBE, 0xD6, 0x5A, 0xD2, 0x36, 0x84, 0x17,
                0x61, 0x53, 0x01, 0x7E, 0xC7, 0x41, 0x8A, 0x19
            };

            Span<byte> a7 = new byte[128] {
                0x6C, 0x7C, 0x67, 0x56, 0xE8, 0x00, 0xB7, 0x81, 0x7D, 0xC0, 0x4D, 0x13,
                0xEB, 0xAB, 0xA4, 0x2E, 0x86, 0x2D, 0xBF, 0xE4, 0x10, 0xFD, 0x11, 0xF0,
                0x45, 0x76, 0xC1, 0x92, 0xF9, 0xAF, 0xE9, 0xF3, 0x05, 0xE7, 0x66, 0x70,
                0xF0, 0xDB, 0xBB, 0x24, 0xE5, 0x9D, 0xAE, 0xF6, 0xF5, 0xB5, 0x7D, 0x66,
                0xAE, 0x59, 0x2B, 0x70, 0x76, 0xE7, 0xFF, 0xB8, 0xCD, 0x97, 0x06, 0xF0,
                0x4E, 0x34, 0xAC, 0x28, 0xDF, 0xC3, 0x4C, 0x2F, 0x4D, 0x37, 0x3C, 0xFD,
                0xB7, 0xE2, 0x85, 0x4C, 0x75, 0x87, 0x31, 0x02, 0x31, 0x2D, 0x3E, 0x91,
                0xF9, 0xAA, 0x77, 0x2A, 0xF2, 0x31, 0x53, 0xD3, 0xBF, 0xC6, 0x5F, 0x54,
                0xDA, 0x15, 0x4A, 0x1C, 0x5C, 0xBE, 0x45, 0x81, 0x52, 0x35, 0xD6, 0xC1,
                0x8B, 0x97, 0x50, 0x3C, 0xB4, 0xA1, 0xEA, 0x25, 0x02, 0xE2, 0x47, 0x42,
                0xD4, 0x02, 0x19, 0x60, 0x84, 0x81, 0x50, 0xE5
            };

            HarpoSeedUtilities.SeedFunction3(a1a4, a2a5, a3a6, a1a4, a2a5, a3a6, a7);

            ReadOnlySpan<byte> a1Expected = new byte[32] {
                0xBB, 0x39, 0x64, 0x8E, 0x14, 0x63, 0x8D, 0x3C, 0xEB, 0xC2, 0xA2, 0xC7,
                0x80, 0xB9, 0x92, 0x8B, 0x97, 0xBA, 0x45, 0x4B, 0x34, 0xFA, 0x7E, 0xD1,
                0x07, 0xA5, 0x04, 0x39, 0xE4, 0xDC, 0x0B, 0xAF
            };
            Assert.That(a1Expected.SequenceEqual(a1a4));

            ReadOnlySpan<byte> a2Expected = new byte[32] {
                0x0A, 0xDF, 0x62, 0x6E, 0x0B, 0x53, 0x56, 0x0B, 0xFB, 0xC9, 0xE0, 0x12,
                0xD9, 0x0E, 0xEA, 0xBE, 0xC0, 0xD3, 0xC6, 0x09, 0xD9, 0xA9, 0x05, 0x08,
                0xF3, 0xD3, 0xB6, 0x9A, 0x30, 0x8C, 0x89, 0x40
            };
            Assert.That(a2Expected.SequenceEqual(a2a5));

            ReadOnlySpan<byte> a3Expected = new byte[32] {
                0x56, 0x08, 0x2C, 0x49, 0xF6, 0xD1, 0x10, 0xEA, 0x6D, 0xB8, 0x51, 0x7A,
                0x81, 0x86, 0xD0, 0x35, 0xEC, 0xD2, 0xCA, 0xFD, 0x2C, 0xED, 0x3F, 0x48,
                0xD4, 0xED, 0xDC, 0xCB, 0x64, 0x23, 0xBC, 0x58
            };
            Assert.That(a3Expected.SequenceEqual(a3a6));

            ReadOnlySpan<byte> a7Expected = new byte[128] {
                0x58, 0x33, 0x61, 0xF3, 0x58, 0xF8, 0xF0, 0x7F, 0x55, 0x9F, 0xB3, 0xA1,
                0x17, 0xE1, 0x8F, 0x81, 0x4C, 0x14, 0x3C, 0x13, 0xAE, 0x0B, 0xF6, 0x7E,
                0xE7, 0x3A, 0xF1, 0xF8, 0x5F, 0xC9, 0x4E, 0x82, 0x8C, 0x3E, 0xA4, 0xCB,
                0x37, 0xF7, 0x92, 0xCC, 0x59, 0x71, 0xF1, 0x70, 0x54, 0x29, 0x83, 0x7C,
                0x10, 0xEB, 0x89, 0xE6, 0x5A, 0x65, 0x20, 0x63, 0x0B, 0xC3, 0xFC, 0x17,
                0xB3, 0x0C, 0x1C, 0xF2, 0x46, 0x52, 0xB2, 0xD9, 0x0D, 0xBF, 0x41, 0x03,
                0x09, 0x0F, 0x6B, 0xCC, 0x0E, 0x87, 0x44, 0x28, 0xAD, 0x14, 0x62, 0x09,
                0x71, 0xBB, 0x23, 0x77, 0x7C, 0x73, 0x04, 0xA5, 0x6B, 0x93, 0x51, 0xDA,
                0xAC, 0x66, 0x0A, 0xF0, 0x7D, 0xF3, 0xBD, 0x7E, 0x88, 0xC5, 0xB9, 0x53,
                0xBF, 0x3C, 0xBB, 0x31, 0x91, 0xC1, 0x91, 0xAA, 0x1B, 0x28, 0xAA, 0x53,
                0xF6, 0xA7, 0x2C, 0xD8, 0x29, 0xEF, 0xBE, 0xB8
            };
            Assert.That(a7Expected.SequenceEqual(a7));
        }

        [Test]
        public void SeedFunction4Test()
        {
            Span<byte> a1a3 = new byte[32] {
                0xBB, 0x39, 0x64, 0x8E, 0x14, 0x63, 0x8D, 0x3C, 0xEB, 0xC2, 0xA2, 0xC7,
                0x80, 0xB9, 0x92, 0x8B, 0x97, 0xBA, 0x45, 0x4B, 0x34, 0xFA, 0x7E, 0xD1,
                0x07, 0xA5, 0x04, 0x39, 0xE4, 0xDC, 0x0B, 0xAF
            };

            Span<byte> a2a5 = new byte[32] {
                0x0A, 0xDF, 0x62, 0x6E, 0x0B, 0x53, 0x56, 0x0B, 0xFB, 0xC9, 0xE0, 0x12,
                0xD9, 0x0E, 0xEA, 0xBE, 0xC0, 0xD3, 0xC6, 0x09, 0xD9, 0xA9, 0x05, 0x08,
                0xF3, 0xD3, 0xB6, 0x9A, 0x30, 0x8C, 0x89, 0x40
            };

            Span<byte> a3a6 = new byte[32] {
                0x56, 0x08, 0x2C, 0x49, 0xF6, 0xD1, 0x10, 0xEA, 0x6D, 0xB8, 0x51, 0x7A,
                0x81, 0x86, 0xD0, 0x35, 0xEC, 0xD2, 0xCA, 0xFD, 0x2C, 0xED, 0x3F, 0x48,
                0xD4, 0xED, 0xDC, 0xCB, 0x64, 0x23, 0xBC, 0x58
            };

            ReadOnlySpan<byte> a7 = new byte[32] {
                0x96, 0xC2, 0x98, 0xD8, 0x45, 0x39, 0xA1, 0xF4, 0xA0, 0x33, 0xEB, 0x2D,
                0x81, 0x7D, 0x03, 0x77, 0xF2, 0x40, 0xA4, 0x63, 0xE5, 0xE6, 0xBC, 0xF8,
                0x47, 0x42, 0x2C, 0xE1, 0xF2, 0xD1, 0x17, 0x6B
            };

            ReadOnlySpan<byte> a8 = new byte[32] {
                0xF5, 0x51, 0xBF, 0x37, 0x68, 0x40, 0xB6, 0xCB, 0xCE, 0x5E, 0x31, 0x6B,
                0x57, 0x33, 0xCE, 0x2B, 0x16, 0x9E, 0x0F, 0x7C, 0x4A, 0xEB, 0xE7, 0x8E,
                0x9B, 0x7F, 0x1A, 0xFE, 0xE2, 0x42, 0xE3, 0x4F
            };

            Span<byte> a9 = new byte[128] {
                0x58, 0x33, 0x61, 0xF3, 0x58, 0xF8, 0xF0, 0x7F, 0x55, 0x9F, 0xB3, 0xA1,
                0x17, 0xE1, 0x8F, 0x81, 0x4C, 0x14, 0x3C, 0x13, 0xAE, 0x0B, 0xF6, 0x7E,
                0xE7, 0x3A, 0xF1, 0xF8, 0x5F, 0xC9, 0x4E, 0x82, 0x8C, 0x3E, 0xA4, 0xCB,
                0x37, 0xF7, 0x92, 0xCC, 0x59, 0x71, 0xF1, 0x70, 0x54, 0x29, 0x83, 0x7C,
                0x10, 0xEB, 0x89, 0xE6, 0x5A, 0x65, 0x20, 0x63, 0x0B, 0xC3, 0xFC, 0x17,
                0xB3, 0x0C, 0x1C, 0xF2, 0x46, 0x52, 0xB2, 0xD9, 0x0D, 0xBF, 0x41, 0x03,
                0x09, 0x0F, 0x6B, 0xCC, 0x0E, 0x87, 0x44, 0x28, 0xAD, 0x14, 0x62, 0x09,
                0x71, 0xBB, 0x23, 0x77, 0x7C, 0x73, 0x04, 0xA5, 0x6B, 0x93, 0x51, 0xDA,
                0xAC, 0x66, 0x0A, 0xF0, 0x7D, 0xF3, 0xBD, 0x7E, 0x88, 0xC5, 0xB9, 0x53,
                0xBF, 0x3C, 0xBB, 0x31, 0x91, 0xC1, 0x91, 0xAA, 0x1B, 0x28, 0xAA, 0x53,
                0xF6, 0xA7, 0x2C, 0xD8, 0x29, 0xEF, 0xBE, 0xB8
            };

            HarpoSeedUtilities.SeedFunction4(a1a3, a2a5, a3a6, a1a3, a2a5, a3a6, a7, a8, a9);

            ReadOnlySpan<byte> a1Expected = new byte[32] {
                0x53, 0xA9, 0x6E, 0xFF, 0x47, 0x28, 0x3A, 0xC3, 0xF7, 0x1D, 0x8B, 0x89,
                0x8D, 0xD8, 0x36, 0x83, 0x32, 0x99, 0x8A, 0xA3, 0x37, 0x5B, 0x18, 0x47,
                0xD9, 0xBB, 0xD4, 0xC9, 0x45, 0x2D, 0xAF, 0x7B
            };
            Assert.That(a1Expected.SequenceEqual(a1a3));

            ReadOnlySpan<byte> a2Expected = new byte[32] {
                0xBD, 0x44, 0x72, 0x21, 0xBC, 0x30, 0xC3, 0x2E, 0x9B, 0x2C, 0x44, 0xB6,
                0xB0, 0xC4, 0xBF, 0x76, 0xD2, 0xF7, 0x0C, 0x51, 0x5D, 0x7B, 0x71, 0xC4,
                0x6F, 0x86, 0x2F, 0x7D, 0x8F, 0xBE, 0xAB, 0xAA
            };
            Assert.That(a2Expected.SequenceEqual(a2a5));

            ReadOnlySpan<byte> a3Expected = new byte[32] {
                0xA6, 0x5C, 0xAD, 0x83, 0x0C, 0x18, 0x21, 0x24, 0x7E, 0x04, 0x9A, 0x80,
                0x5F, 0x5E, 0x0B, 0x31, 0xA8, 0x11, 0x7A, 0xD3, 0xEA, 0x2D, 0xAF, 0x5C,
                0xE3, 0xD7, 0xA6, 0x3E, 0xCD, 0x22, 0x09, 0x6E
            };
            Assert.That(a3Expected.SequenceEqual(a3a6));

            ReadOnlySpan<byte> a9Expected = new byte[128] {
                0x60, 0x1C, 0xB2, 0x54, 0xE3, 0x62, 0x97, 0x97, 0x1E, 0x4F, 0x69, 0x80,
                0x24, 0xC2, 0x20, 0x76, 0x0D, 0x65, 0x96, 0x6C, 0x60, 0x29, 0x0D, 0x8E,
                0x87, 0xA2, 0x34, 0x54, 0xA6, 0x39, 0xE7, 0x13, 0x47, 0x39, 0x2B, 0x0C,
                0x57, 0x54, 0x41, 0x46, 0x6E, 0xB0, 0xF3, 0x1C, 0x99, 0x52, 0x98, 0x26,
                0xAA, 0xD2, 0xFE, 0x69, 0x86, 0x8C, 0x2A, 0xDC, 0xF0, 0x64, 0x92, 0x34,
                0x13, 0x4B, 0xC9, 0x15, 0xAC, 0x42, 0xA1, 0xD4, 0x8F, 0x57, 0x67, 0x77,
                0xF4, 0x61, 0x40, 0x7A, 0x5E, 0xA7, 0xDB, 0x8F, 0x20, 0x32, 0xC4, 0x5C,
                0xCE, 0x12, 0x50, 0x70, 0x4E, 0xD4, 0x5F, 0xBE, 0x2D, 0xBD, 0xEB, 0xDA,
                0x25, 0x49, 0xD1, 0xD5, 0x49, 0x1C, 0x43, 0x69, 0xB5, 0x9E, 0xA0, 0xFA,
                0x28, 0x4A, 0x32, 0xC7, 0xC3, 0x4A, 0x92, 0x4D, 0x10, 0xBC, 0xC5, 0x86,
                0x90, 0x3A, 0x76, 0xF7, 0xF0, 0xB2, 0x2F, 0xAE
            };
            Assert.That(a9Expected.SequenceEqual(a9));
        }

        [Test]
        [TestCaseSource(nameof(SeedFunction5TestData))]
        public void SeedFunction5Test(byte[] a1, byte[] a2, byte[] a3, byte[] a4, byte[] a1Expected)
        {
            HarpoSeedUtilities.SeedFunction5(a1, a2, a3, a4);
            Assert.That(a1Expected.SequenceEqual(a1));
        }

        // fuck yeah, it passed
        [Test]
        [TestCaseSource(nameof(SeedFunction2TestData))]
        public void SeedFunction2Test(byte[] a1, byte[] a2, byte[] a3, int a4, byte[] a1Expected)
        {
            HarpoSeedUtilities.SeedFunction2(a1, a2, a3, a4);
            Assert.That(a1.AsSpan().SequenceEqual(a1Expected.AsSpan()));
        }

        [Test]
        [TestCase(
            arg1: new byte[32]
            {
                0x50, 0x8B, 0xB3, 0x2B, 0x88, 0x07, 0x3E, 0xF3, 0x62, 0x29, 0x45, 0xA0,
                0xE1, 0x0A, 0x94, 0x88, 0x38, 0xBA, 0x51, 0xAE, 0xB3, 0xF7, 0xCF, 0x14,
                0x20, 0x21, 0x8E, 0x00, 0x73, 0x23, 0xE0, 0xE0
            },
            arg2: 0UL,
            ExpectedResult = new byte[32]
            {
                0xA8, 0xC5, 0xD9, 0x15, 0xC4, 0x03, 0x9F, 0x79, 0xB1, 0x94, 0x22, 0xD0,
                0x70, 0x05, 0x4A, 0x44, 0x1C, 0xDD, 0x28, 0xD7, 0xD9, 0xFB, 0x67, 0x0A,
                0x90, 0x10, 0x47, 0x80, 0xB9, 0x11, 0x70, 0x70
            }
        )]
        [TestCase(
            arg1: new byte[32]
            {
                0xFE, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F,
                0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80,
                0x01, 0x00, 0x00, 0x80, 0xFE, 0xFF, 0xFF, 0x7F
            },
            arg2: 1UL,
            ExpectedResult = new byte[32]
            {
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xBF,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC0,
                0x00, 0x00, 0x00, 0x40, 0xFF, 0xFF, 0xFF, 0xBF
            }
        )]
        public byte[] PubKeyOp19Test(byte[] a1, ulong a2)
        {
            HarpoSeedUtilities.PubKeyOp19(a1, a2);
            return a1;
        }

        [Test]
        public void PubKeyOp18Test()
        {
            Span<byte> a1 = new byte[32] {
                0xFA, 0x3B, 0x91, 0x51, 0xFF, 0x17, 0x8E, 0xDD, 0x06, 0x84, 0xB6, 0x45,
                0x71, 0xB4, 0xE2, 0xEE, 0x23, 0x2A, 0xC9, 0x16, 0xD1, 0x08, 0xE3, 0xE9,
                0xCE, 0xFC, 0x68, 0xCF, 0x54, 0xDA, 0x11, 0x11
            };
            Span<byte> a2 = new byte[32] {
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x88,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x88,
                0x00, 0x00, 0x00, 0x78, 0xFF, 0xFF, 0xFF, 0x87
            };

            HarpoSeedUtilities.PubKeyOp18(a1, a2, SeedConsts.Mask.Span);

            ReadOnlySpan<byte> a1Expected = new byte[32] {
                0xFD, 0x9D, 0xC8, 0xA8, 0xFF, 0x0B, 0xC7, 0x6E, 0x03, 0x42, 0xDB, 0xA2,
                0x38, 0x5A, 0x71, 0xF7, 0x11, 0x95, 0x64, 0x8B, 0x68, 0x84, 0xF1, 0x74,
                0x67, 0x7E, 0xB4, 0x67, 0x2A, 0xED, 0x88, 0x08
            };
            Assert.That(a1Expected.SequenceEqual(a1));

            ReadOnlySpan<byte> a2Expected = new byte[32] {
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x44,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x44,
                0x00, 0x00, 0x00, 0xBC, 0xFF, 0xFF, 0xFF, 0x43
            };
            Assert.That(a2Expected.SequenceEqual(a2));
        }

        [Test]
        public void PubKeyOp17Test()
        {
            Span<byte> a1a3 = new byte[32] {
                0x5E, 0xE9, 0x98, 0xA8, 0xEF, 0xF0, 0x83, 0x19, 0x3A, 0xAD, 0x75, 0xBF,
                0x3E, 0xEA, 0xD7, 0xEE, 0x8E, 0x8B, 0x5C, 0xA3, 0x98, 0x10, 0x60, 0xD6,
                0xC1, 0xBD, 0xE3, 0xFE, 0x17, 0xB9, 0x3F, 0x3E
            };

            HarpoSeedUtilities.PubKeyOp17(a1a3, SeedConsts.Mask4.Span, a1a3, SeedConsts.Mask.Span);

            ReadOnlySpan<byte> a1Expected = new byte[32] {
                0x92, 0x55, 0xE2, 0x2B, 0xA6, 0x14, 0x82, 0xCE, 0x31, 0xA8, 0xAB, 0x8F,
                0x32, 0xD6, 0xA1, 0x10, 0xB8, 0xF3, 0x49, 0xF3, 0x1B, 0xD9, 0x91, 0xB9,
                0x56, 0xC3, 0xF4, 0xA7, 0xA6, 0xAC, 0x80, 0x99
            };
            Assert.That(a1Expected.SequenceEqual(a1a3));
        }
}