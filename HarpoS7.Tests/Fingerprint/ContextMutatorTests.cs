using System.Runtime.InteropServices;
using HarpoS7.Fingerprint;

namespace HarpoS7.Tests.Fingerprint;

public class ContextMutatorTests
{
    public static IEnumerable<TestCaseData> MutateStatic4TestCases
        {
            get
            {
                var static4_0 = new uint[FingerprintConsts.BigContextLengthDword];
                FingerprintConsts.BigContextInitialValue.CopyTo(static4_0.AsSpan());

                var expected_0 = GetExpectedStatic4(new byte[188] {
                    0xF2, 0x41, 0x6B, 0xDA, 0x95, 0x86, 0x9E, 0x78, 0x00, 0x20, 0x64, 0x18,
                    0x13, 0xEF, 0xAB, 0xE0, 0x00, 0x9E, 0x69, 0x08, 0x95, 0xB2, 0x54, 0xC4,
                    0x6D, 0xA9, 0x9D, 0x06, 0xB6, 0xE3, 0x98, 0x48, 0x60, 0xD3, 0x7B, 0x15,
                    0x21, 0x2F, 0xA3, 0x67, 0x99, 0x16, 0x25, 0xDB, 0x45, 0x97, 0x8B, 0x88,
                    0xFA, 0x20, 0x00, 0x00, 0x73, 0xEB, 0xBD, 0xE7, 0x25, 0xAA, 0xFD, 0x06,
                    0x02, 0x79, 0x61, 0xC9, 0xE9, 0x5C, 0x75, 0xFC, 0xCE, 0xA1, 0xAD, 0xED,
                    0xCA, 0x6E, 0xD5, 0x66, 0xFA, 0x2C, 0xCA, 0x17, 0x2D, 0xCB, 0xBC, 0x0D,
                    0xFE, 0xF4, 0x2C, 0xB4, 0x5C, 0xF4, 0x1E, 0x21, 0x73, 0x4E, 0xB9, 0x7A,
                    0x5D, 0x81, 0x28, 0x9E, 0xF6, 0x0F, 0x18, 0x91, 0xF6, 0x7A, 0x59, 0x67,
                    0x0B, 0x28, 0xB2, 0xA0, 0x41, 0xBC, 0x61, 0xDF, 0xCB, 0x46, 0x78, 0x73,
                    0x9F, 0x47, 0x6A, 0x0D, 0x37, 0x35, 0xB2, 0xAB, 0x79, 0x99, 0x72, 0x20,
                    0x48, 0x55, 0x2C, 0x01, 0xCE, 0x75, 0x6A, 0xFF, 0x78, 0xFC, 0xC6, 0xBC,
                    0xE8, 0x0F, 0xB1, 0x20, 0x4D, 0xB8, 0xA7, 0x5A, 0x66, 0xFE, 0xE3, 0x28,
                    0x8A, 0x2A, 0x07, 0xD0, 0x44, 0x0F, 0x2C, 0xB5, 0x6E, 0x3F, 0x5C, 0x00,
                    0xB0, 0xF7, 0xD7, 0x61, 0xDC, 0x73, 0xC0, 0xB7, 0xDC, 0x59, 0x56, 0x36,
                    0xDA, 0x8C, 0x7C, 0xFE, 0x55, 0xE3, 0x44, 0x0D
                });
                yield return new TestCaseData(static4_0, 0, expected_0);

                var static4_1 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_0.CopyTo(static4_1.AsSpan());
                var expected_1 = GetExpectedStatic4(new byte[188]
                {
                    0xFE, 0x46, 0x4C, 0xBF, 0x1A, 0x08, 0x35, 0xCA, 0x00, 0x20, 0x64, 0x18,
                    0x13, 0xEF, 0xAB, 0xE0, 0x00, 0x9E, 0x69, 0x08, 0xD1, 0x82, 0xD3, 0x5C,
                    0x67, 0x9F, 0xAF, 0x25, 0xDE, 0xA5, 0xBB, 0x2B, 0xA0, 0xDC, 0xB8, 0x25,
                    0x21, 0x2F, 0xA3, 0x67, 0x99, 0x16, 0x25, 0xDB, 0x45, 0x97, 0x8B, 0x88,
                    0xFA, 0x20, 0x00, 0x00, 0x78, 0x7C, 0x5E, 0x8F, 0x25, 0xAA, 0xFD, 0x06,
                    0x02, 0x79, 0x61, 0xC9, 0xE9, 0x5C, 0x75, 0xFC, 0xCE, 0xA1, 0xAD, 0xED,
                    0xCA, 0x6E, 0xD5, 0x66, 0xFA, 0x2C, 0xCA, 0x17, 0x2D, 0xCB, 0xBC, 0x0D,
                    0xFE, 0xF4, 0x2C, 0xB4, 0x5C, 0xF4, 0x1E, 0x21, 0x73, 0x4E, 0xB9, 0x7A,
                    0x5D, 0x81, 0x28, 0x9E, 0xF6, 0x0F, 0x18, 0x91, 0xF6, 0x7A, 0x59, 0x67,
                    0x0B, 0x28, 0xB2, 0xA0, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0xA3, 0x6D, 0x83, 0x7C, 0x37, 0x35, 0xB2, 0xAB, 0x9A, 0x00, 0x1E, 0xC0,
                    0x48, 0x55, 0x2C, 0x01, 0xCE, 0x75, 0x6A, 0xFF, 0x78, 0xFC, 0xC6, 0xBC,
                    0xE8, 0x0F, 0xB1, 0x20, 0x85, 0x0B, 0x0D, 0x1F, 0x66, 0xFE, 0xE3, 0x28,
                    0x8A, 0x2A, 0x07, 0xD0, 0x03, 0x3A, 0x86, 0x39, 0x6E, 0x3F, 0x5C, 0x00,
                    0xB0, 0xF7, 0xD7, 0x61, 0xDC, 0x73, 0xC0, 0xB7, 0xDC, 0x59, 0x56, 0x36,
                    0xDA, 0x8C, 0x7C, 0xFE, 0x55, 0xE3, 0x44, 0x0D,
                });
                yield return new TestCaseData(static4_1, 1, expected_1);

                var static4_2 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_1.CopyTo(static4_2.AsSpan());
                var expected_2 = GetExpectedStatic4(new byte[188]
                {
                    0xFE, 0x46, 0x4C, 0xBF, 0x1A, 0x08, 0x35, 0xCA, 0x00, 0x20, 0x64, 0x18,
                    0xCB, 0x2C, 0xE0, 0x68, 0x00, 0x9E, 0x69, 0x08, 0x8B, 0xB6, 0x90, 0x06,
                    0x67, 0x9F, 0xAF, 0x25, 0xDE, 0xA5, 0xBB, 0x2B, 0xE0, 0x80, 0x72, 0xE0,
                    0x21, 0x2F, 0xA3, 0x67, 0x99, 0x16, 0x25, 0xDB, 0x45, 0x97, 0x8B, 0x88,
                    0x48, 0xFC, 0xA5, 0x3E, 0x78, 0x7C, 0x5E, 0x8F, 0x53, 0x73, 0xDB, 0x8F,
                    0xCC, 0x97, 0xF5, 0x70, 0xE9, 0x5C, 0x75, 0xFC, 0x9C, 0x0D, 0x21, 0xEF,
                    0xCA, 0x6E, 0xD5, 0x66, 0xFA, 0x2C, 0xCA, 0x17, 0xA3, 0x72, 0x49, 0xA7,
                    0xFE, 0xF4, 0x2C, 0xB4, 0x5C, 0xF4, 0x1E, 0x21, 0x73, 0x4E, 0xB9, 0x7A,
                    0x5D, 0x81, 0x28, 0x9E, 0xF6, 0x0F, 0x18, 0x91, 0xF6, 0x7A, 0x59, 0x67,
                    0x0B, 0x28, 0xB2, 0xA0, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0xA3, 0x6D, 0x83, 0x7C, 0x37, 0x35, 0xB2, 0xAB, 0x9A, 0x00, 0x1E, 0xC0,
                    0x48, 0x55, 0x2C, 0x01, 0xCE, 0x75, 0x6A, 0xFF, 0x78, 0xFC, 0xC6, 0xBC,
                    0xB3, 0x66, 0xF7, 0x06, 0x6E, 0x47, 0x50, 0xC1, 0x79, 0x96, 0x8C, 0x8F,
                    0x8A, 0x2A, 0x07, 0xD0, 0x03, 0x3A, 0x86, 0x39, 0x6E, 0x3F, 0x5C, 0x00,
                    0x9C, 0x9F, 0xA1, 0xAE, 0x97, 0x78, 0xC6, 0xFC, 0xDC, 0x59, 0x56, 0x36,
                    0xDA, 0x8C, 0x7C, 0xFE, 0xD0, 0xE3, 0x51, 0x5E,
                });
                yield return new TestCaseData(static4_2, 2, expected_2);

                var static4_3 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_2.CopyTo(static4_3.AsSpan());
                var expected_3 = GetExpectedStatic4(new byte[188]
                {
                    0xFE, 0x46, 0x4C, 0xBF, 0xC7, 0x38, 0xFB, 0x66, 0x00, 0x20, 0x64, 0x18,
                    0xCB, 0x2C, 0xE0, 0x68, 0xEB, 0x77, 0x22, 0xAA, 0x8B, 0xB6, 0x90, 0x06,
                    0x67, 0x9F, 0xAF, 0x25, 0xDE, 0xA5, 0xBB, 0x2B, 0xE0, 0x80, 0x72, 0xE0,
                    0x21, 0x2F, 0xA3, 0x67, 0x99, 0x16, 0x25, 0xDB, 0x45, 0x97, 0x8B, 0x88,
                    0xC2, 0x1D, 0x3C, 0x36, 0x78, 0x7C, 0x5E, 0x8F, 0x53, 0x73, 0xDB, 0x8F,
                    0xC8, 0x94, 0x7C, 0x82, 0x91, 0x01, 0x1A, 0x1C, 0x9C, 0x0D, 0x21, 0xEF,
                    0x69, 0xAA, 0xB5, 0x3A, 0xFA, 0x2C, 0xCA, 0x17, 0x4B, 0x53, 0xFC, 0x41,
                    0xFE, 0xF4, 0x2C, 0xB4, 0x5C, 0xF4, 0x1E, 0x21, 0x73, 0x4E, 0xB9, 0x7A,
                    0x5D, 0x81, 0x28, 0x9E, 0xF6, 0x0F, 0x18, 0x91, 0xF6, 0x7A, 0x59, 0x67,
                    0x3D, 0x6D, 0xCD, 0x4D, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0x82, 0x84, 0xDB, 0xF8, 0x53, 0xDD, 0x4F, 0x44, 0x9A, 0x00, 0x1E, 0xC0,
                    0x62, 0xE0, 0x5F, 0xE0, 0xCE, 0x75, 0x6A, 0xFF, 0x78, 0xFC, 0xC6, 0xBC,
                    0x50, 0xF0, 0x28, 0x8D, 0x6E, 0x47, 0x50, 0xC1, 0xDA, 0x37, 0x64, 0x83,
                    0x8A, 0x2A, 0x07, 0xD0, 0x2F, 0x29, 0x7A, 0x10, 0x6E, 0x3F, 0x5C, 0x00,
                    0x9C, 0x9F, 0xA1, 0xAE, 0xF9, 0x40, 0xAC, 0x87, 0xDC, 0x59, 0x56, 0x36,
                    0xDA, 0x8C, 0x7C, 0xFE, 0xD0, 0xE3, 0x51, 0x5E,
                });
                yield return new TestCaseData(static4_3, 3, expected_3);

                var static4_4 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_3.CopyTo(static4_4.AsSpan());
                var expected_4 = GetExpectedStatic4(new byte[188]
                {
                    0xFE, 0x46, 0x4C, 0xBF, 0xC7, 0x38, 0xFB, 0x66, 0x2B, 0x96, 0x26, 0xC7,
                    0x0F, 0xA6, 0x82, 0xE7, 0xF1, 0x5F, 0xED, 0xB7, 0x8B, 0xB6, 0x90, 0x06,
                    0xA1, 0x2B, 0x9D, 0x47, 0xFC, 0x1F, 0xB9, 0xCA, 0xE0, 0x80, 0x72, 0xE0,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x99, 0x16, 0x25, 0xDB, 0x45, 0x97, 0x8B, 0x88,
                    0xC2, 0x1D, 0x3C, 0x36, 0xD8, 0xAC, 0x0A, 0xF3, 0x53, 0x73, 0xDB, 0x8F,
                    0xC8, 0x94, 0x7C, 0x82, 0x91, 0x01, 0x1A, 0x1C, 0x9C, 0x0D, 0x21, 0xEF,
                    0x49, 0x19, 0xB6, 0x3B, 0xFA, 0x2C, 0xCA, 0x17, 0x4B, 0x53, 0xFC, 0x41,
                    0xF2, 0x0A, 0x41, 0x4A, 0x95, 0x83, 0x38, 0x57, 0x73, 0x4E, 0xB9, 0x7A,
                    0x94, 0x19, 0xFB, 0xE1, 0x43, 0x8B, 0x84, 0x31, 0xF6, 0x7A, 0x59, 0x67,
                    0x3D, 0x6D, 0xCD, 0x4D, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0x82, 0x84, 0xDB, 0xF8, 0xF8, 0x73, 0x48, 0xAA, 0x9A, 0x00, 0x1E, 0xC0,
                    0x62, 0xE0, 0x5F, 0xE0, 0x81, 0x8D, 0x1D, 0x5F, 0x78, 0xFC, 0xC6, 0xBC,
                    0x70, 0xFF, 0x3B, 0xF6, 0xE0, 0x22, 0x87, 0x45, 0xDA, 0x37, 0x64, 0x83,
                    0x8A, 0x2A, 0x07, 0xD0, 0x2F, 0x29, 0x7A, 0x10, 0x26, 0x32, 0xBE, 0x03,
                    0x2C, 0x80, 0x8A, 0x32, 0xEB, 0xF7, 0xD4, 0x33, 0x43, 0x9C, 0x29, 0xF1,
                    0x5E, 0x6E, 0x59, 0x0A, 0xD0, 0xE3, 0x51, 0x5E,
                });
                yield return new TestCaseData(static4_4, 4, expected_4);

                var static4_5 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_4.CopyTo(static4_5.AsSpan());
                var expected_5 = GetExpectedStatic4(new byte[188]
                {
                    0xFE, 0x46, 0x4C, 0xBF, 0xC7, 0x38, 0xFB, 0x66, 0x2B, 0x96, 0x26, 0xC7,
                    0xF1, 0x0B, 0xF4, 0x05, 0xF1, 0x5F, 0xED, 0xB7, 0x8B, 0xB6, 0x90, 0x06,
                    0xA1, 0x2B, 0x9D, 0x47, 0xFC, 0x1F, 0xB9, 0xCA, 0xE0, 0x80, 0x72, 0xE0,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x99, 0x16, 0x25, 0xDB, 0x0D, 0x36, 0x56, 0x80,
                    0xCB, 0xC0, 0xC0, 0x1B, 0xD8, 0xAC, 0x0A, 0xF3, 0x53, 0x73, 0xDB, 0x8F,
                    0x65, 0x50, 0x8A, 0x3B, 0x91, 0x01, 0x1A, 0x1C, 0x9C, 0x0D, 0x21, 0xEF,
                    0x49, 0x19, 0xB6, 0x3B, 0xFA, 0x2C, 0xCA, 0x17, 0x4B, 0x53, 0xFC, 0x41,
                    0xF2, 0x0A, 0x41, 0x4A, 0x95, 0x83, 0x38, 0x57, 0x73, 0x4E, 0xB9, 0x7A,
                    0x94, 0x19, 0xFB, 0xE1, 0x43, 0x8B, 0x84, 0x31, 0xF6, 0x7A, 0x59, 0x67,
                    0x3D, 0x6D, 0xCD, 0x4D, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0x15, 0xEE, 0xD7, 0x84, 0xF8, 0x73, 0x48, 0xAA, 0xAA, 0x8E, 0x6B, 0xF1,
                    0x62, 0xE0, 0x5F, 0xE0, 0x81, 0x8D, 0x1D, 0x5F, 0x78, 0xFC, 0xC6, 0xBC,
                    0x58, 0x9D, 0x60, 0x46, 0xE0, 0x22, 0x87, 0x45, 0xDA, 0x37, 0x64, 0x83,
                    0x8A, 0x2A, 0x07, 0xD0, 0xDE, 0x42, 0xA2, 0x16, 0x25, 0xCE, 0x94, 0x8D,
                    0x2C, 0x80, 0x8A, 0x32, 0xEB, 0xF7, 0xD4, 0x33, 0x43, 0x9C, 0x29, 0xF1,
                    0x5E, 0x6E, 0x59, 0x0A, 0xD0, 0xE3, 0x51, 0x5E,
                });
                yield return new TestCaseData(static4_5, 5, expected_5);

                var static4_6 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_5.CopyTo(static4_6.AsSpan());
                var expected_6 = GetExpectedStatic4(new byte[188]
                {
                    0x36, 0xAE, 0x13, 0x17, 0xC7, 0x38, 0xFB, 0x66, 0x46, 0x7D, 0xE1, 0xFD,
                    0x4C, 0x36, 0x8F, 0xCF, 0x6A, 0x85, 0xB5, 0x83, 0x8B, 0xB6, 0x90, 0x06,
                    0xA1, 0x2B, 0x9D, 0x47, 0xFD, 0x0C, 0xBB, 0x53, 0xFE, 0x6C, 0xC7, 0x14,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x99, 0x16, 0x25, 0xDB, 0x0D, 0x36, 0x56, 0x80,
                    0xCB, 0xC0, 0xC0, 0x1B, 0xD8, 0xAC, 0x0A, 0xF3, 0xDD, 0x87, 0x95, 0x78,
                    0x99, 0x95, 0xAD, 0x0A, 0x53, 0x79, 0x7A, 0x35, 0x55, 0xBD, 0x86, 0x38,
                    0x49, 0x19, 0xB6, 0x3B, 0xFA, 0x2C, 0xCA, 0x17, 0x4B, 0x53, 0xFC, 0x41,
                    0x9E, 0xBE, 0xAB, 0xAA, 0x56, 0xDA, 0xCC, 0x6A, 0xA9, 0x51, 0x91, 0xB5,
                    0x94, 0x19, 0xFB, 0xE1, 0x45, 0x58, 0x8D, 0x99, 0xF6, 0x7A, 0x59, 0x67,
                    0x3D, 0x6D, 0xCD, 0x4D, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0x15, 0xEE, 0xD7, 0x84, 0xDA, 0xAF, 0xF7, 0x22, 0xAA, 0x8E, 0x6B, 0xF1,
                    0xC2, 0x5C, 0x84, 0x92, 0x81, 0x8D, 0x1D, 0x5F, 0x68, 0xC3, 0x26, 0x95,
                    0xE8, 0xF8, 0xEB, 0xFB, 0xE0, 0x22, 0x87, 0x45, 0xDA, 0x37, 0x64, 0x83,
                    0xCE, 0xE5, 0xCD, 0x8D, 0x8E, 0xE6, 0xC4, 0x67, 0xAA, 0x90, 0x74, 0x6F,
                    0x2C, 0x80, 0x8A, 0x32, 0x8F, 0x60, 0x5B, 0xAA, 0x43, 0x9C, 0x29, 0xF1,
                    0x5E, 0x6E, 0x59, 0x0A, 0xD0, 0xE3, 0x51, 0x5E,
                });
                yield return new TestCaseData(static4_6, 6, expected_6);

                var static4_7 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_6.CopyTo(static4_7.AsSpan());
                var expected_7 = GetExpectedStatic4(new byte[188]
                {
                    0x36, 0xAE, 0x13, 0x17, 0xC7, 0x38, 0xFB, 0x66, 0x42, 0x3B, 0x45, 0x37,
                    0xDC, 0x52, 0xE4, 0x17, 0x6A, 0x85, 0xB5, 0x83, 0xF4, 0x17, 0xDD, 0xEA,
                    0xA1, 0x2B, 0x9D, 0x47, 0xCD, 0xC6, 0xD5, 0x6E, 0xFE, 0x6C, 0xC7, 0x14,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x99, 0x16, 0x25, 0xDB, 0x5D, 0x43, 0x48, 0x23,
                    0xCB, 0xC0, 0xC0, 0x1B, 0xD8, 0xAC, 0x0A, 0xF3, 0xDD, 0x87, 0x95, 0x78,
                    0x99, 0x95, 0xAD, 0x0A, 0x73, 0x52, 0xD1, 0x58, 0x55, 0xBD, 0x86, 0x38,
                    0x49, 0x19, 0xB6, 0x3B, 0xFA, 0x2C, 0xCA, 0x17, 0x50, 0x88, 0x25, 0x96,
                    0x9E, 0xBE, 0xAB, 0xAA, 0x56, 0xDA, 0xCC, 0x6A, 0xA9, 0x51, 0x91, 0xB5,
                    0x94, 0x19, 0xFB, 0xE1, 0x3B, 0x31, 0x5C, 0x12, 0xF6, 0x7A, 0x59, 0x67,
                    0x3D, 0x6D, 0xCD, 0x4D, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0x15, 0xEE, 0xD7, 0x84, 0xDA, 0xAF, 0xF7, 0x22, 0xAA, 0x8E, 0x6B, 0xF1,
                    0xC2, 0x5C, 0x84, 0x92, 0x81, 0x8D, 0x1D, 0x5F, 0x68, 0xC3, 0x26, 0x95,
                    0x36, 0xA4, 0xA4, 0x33, 0xE0, 0x22, 0x87, 0x45, 0xDA, 0x37, 0x64, 0x83,
                    0x4C, 0x46, 0x75, 0x1B, 0x8E, 0xE6, 0xC4, 0x67, 0x9B, 0xCA, 0xCB, 0x49,
                    0x54, 0x8D, 0x9F, 0xDF, 0x8F, 0x60, 0x5B, 0xAA, 0x43, 0x9C, 0x29, 0xF1,
                    0xE1, 0xD8, 0x70, 0x0A, 0xD0, 0xE3, 0x51, 0x5E,
                });
                yield return new TestCaseData(static4_7, 7, expected_7);

                var static4_8 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_7.CopyTo(static4_8.AsSpan());
                var expected_8 = GetExpectedStatic4(new byte[188]
                {
                    0x36, 0xAE, 0x13, 0x17, 0xC7, 0x38, 0xFB, 0x66, 0x42, 0x3B, 0x45, 0x37,
                    0xD7, 0x5C, 0xBA, 0x14, 0x6A, 0x85, 0xB5, 0x83, 0xF4, 0x17, 0xDD, 0xEA,
                    0xA1, 0x2B, 0x9D, 0x47, 0x95, 0x39, 0x43, 0x5C, 0x50, 0x55, 0xCB, 0xBF,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x99, 0x16, 0x25, 0xDB, 0x5D, 0x43, 0x48, 0x23,
                    0xCB, 0xC0, 0xC0, 0x1B, 0x28, 0xAA, 0x14, 0x9D, 0xDD, 0x87, 0x95, 0x78,
                    0xAE, 0xC6, 0x27, 0x4E, 0x73, 0x52, 0xD1, 0x58, 0x11, 0x7D, 0x8F, 0x65,
                    0xEB, 0x3C, 0xFB, 0x4D, 0xBE, 0xBD, 0x46, 0x71, 0x73, 0x0C, 0x7D, 0x2F,
                    0x39, 0x7F, 0xE3, 0xD9, 0x56, 0xDA, 0xCC, 0x6A, 0xA9, 0x51, 0x91, 0xB5,
                    0x8C, 0xC2, 0xA1, 0x27, 0x3B, 0x31, 0x5C, 0x12, 0xF6, 0x7A, 0x59, 0x67,
                    0x8D, 0x43, 0x5D, 0xEB, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0x15, 0xEE, 0xD7, 0x84, 0xDA, 0xAF, 0xF7, 0x22, 0x17, 0x89, 0x15, 0xBB,
                    0xC2, 0x5C, 0x84, 0x92, 0x81, 0x8D, 0x1D, 0x5F, 0xFA, 0xFB, 0x75, 0x2B,
                    0x36, 0xA4, 0xA4, 0x33, 0xE0, 0x22, 0x87, 0x45, 0xDA, 0x37, 0x64, 0x83,
                    0x84, 0xFC, 0x0E, 0x80, 0x8E, 0xE6, 0xC4, 0x67, 0xDA, 0x7F, 0xFA, 0x95,
                    0x54, 0x8D, 0x9F, 0xDF, 0x8F, 0x60, 0x5B, 0xAA, 0x43, 0x9C, 0x29, 0xF1,
                    0xE1, 0xD8, 0x70, 0x0A, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_8, 8, expected_8);

                var static4_9 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_8.CopyTo(static4_9.AsSpan());
                var expected_9 = GetExpectedStatic4(new byte[188]
                {
                    0x36, 0xAE, 0x13, 0x17, 0xE9, 0x11, 0xC2, 0x21, 0x50, 0xF3, 0x83, 0x86,
                    0xD7, 0x5C, 0xBA, 0x14, 0x6A, 0x85, 0xB5, 0x83, 0xF4, 0x17, 0xDD, 0xEA,
                    0xA1, 0x2B, 0x9D, 0x47, 0x95, 0x39, 0x43, 0x5C, 0xF0, 0x38, 0x69, 0xF6,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x99, 0x16, 0x25, 0xDB, 0x5D, 0x43, 0x48, 0x23,
                    0xFD, 0x3E, 0xD2, 0x34, 0x28, 0xAA, 0x14, 0x9D, 0xDD, 0x87, 0x95, 0x78,
                    0xCE, 0xF4, 0x2F, 0x1D, 0x73, 0x52, 0xD1, 0x58, 0x3D, 0x53, 0xDE, 0x5E,
                    0xEB, 0x3C, 0xFB, 0x4D, 0xBE, 0xBD, 0x46, 0x71, 0x73, 0x0C, 0x7D, 0x2F,
                    0x39, 0x7F, 0xE3, 0xD9, 0x56, 0xDA, 0xCC, 0x6A, 0xA9, 0x51, 0x91, 0xB5,
                    0xC7, 0xF9, 0x27, 0x04, 0x3B, 0x31, 0x5C, 0x12, 0xF6, 0x7A, 0x59, 0x67,
                    0x8D, 0x43, 0x5D, 0xEB, 0x41, 0xBC, 0x61, 0xDF, 0x83, 0x8F, 0x3F, 0x10,
                    0x15, 0xEE, 0xD7, 0x84, 0xDA, 0xAF, 0xF7, 0x22, 0x17, 0x89, 0x15, 0xBB,
                    0xC2, 0x5C, 0x84, 0x92, 0xBB, 0xB5, 0x87, 0x12, 0xFA, 0xFB, 0x75, 0x2B,
                    0x36, 0xA4, 0xA4, 0x33, 0xE0, 0x22, 0x87, 0x45, 0xDA, 0x37, 0x64, 0x83,
                    0x9C, 0x0F, 0x45, 0x3A, 0x8E, 0xE6, 0xC4, 0x67, 0xDA, 0x7F, 0xFA, 0x95,
                    0x54, 0x8D, 0x9F, 0xDF, 0x8F, 0x60, 0x5B, 0xAA, 0xE5, 0x0B, 0x79, 0x2D,
                    0xE1, 0xD8, 0x70, 0x0A, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_9, 9, expected_9);

                var static4_10 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_9.CopyTo(static4_10.AsSpan());
                var expected_10 = GetExpectedStatic4(new byte[188]
                {
                    0x36, 0xAE, 0x13, 0x17, 0xE9, 0x11, 0xC2, 0x21, 0x50, 0xF3, 0x83, 0x86,
                    0xD7, 0x5C, 0xBA, 0x14, 0x6A, 0x85, 0xB5, 0x83, 0xF4, 0x17, 0xDD, 0xEA,
                    0xB1, 0x13, 0x5D, 0xCC, 0xD2, 0xE6, 0x89, 0x19, 0x36, 0x1D, 0xD1, 0xA4,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x99, 0x16, 0x25, 0xDB, 0x33, 0xCD, 0xDC, 0x87,
                    0xFE, 0x7E, 0xA1, 0x27, 0x73, 0x1E, 0xEA, 0xC9, 0x85, 0x8D, 0xDE, 0xC8,
                    0xCE, 0xF4, 0x2F, 0x1D, 0x5F, 0x13, 0xE7, 0x3E, 0xE4, 0xF8, 0x6D, 0x80,
                    0xEB, 0x3C, 0xFB, 0x4D, 0xC2, 0x8A, 0x5E, 0xA9, 0x1D, 0xB3, 0x5A, 0x21,
                    0x39, 0x7F, 0xE3, 0xD9, 0xC5, 0x09, 0x9D, 0x7C, 0x23, 0x1D, 0x25, 0xA5,
                    0x12, 0x41, 0x0C, 0xC3, 0x3B, 0x31, 0x5C, 0x12, 0xF6, 0x7A, 0x59, 0x67,
                    0x8D, 0x43, 0x5D, 0xEB, 0x41, 0xBC, 0x61, 0xDF, 0x1D, 0x25, 0xF9, 0xC0,
                    0x15, 0xEE, 0xD7, 0x84, 0xDA, 0xAF, 0xF7, 0x22, 0x3A, 0xF2, 0x6B, 0x57,
                    0xFB, 0xBD, 0xA6, 0xE0, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x36, 0xA4, 0xA4, 0x33, 0xE0, 0x22, 0x87, 0x45, 0xDA, 0x37, 0x64, 0x83,
                    0x9C, 0x0F, 0x45, 0x3A, 0x69, 0x64, 0xCF, 0xEF, 0xDA, 0x7F, 0xFA, 0x95,
                    0xF9, 0x0F, 0x53, 0x70, 0xD3, 0xEB, 0xA9, 0x59, 0x25, 0x23, 0x59, 0x4F,
                    0xE1, 0xD8, 0x70, 0x0A, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_10, 10, expected_10);

                var static4_11 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_10.CopyTo(static4_11.AsSpan());
                var expected_11 = GetExpectedStatic4(new byte[188]
                {
                    0xF4, 0x1E, 0x77, 0xF1, 0xE9, 0x11, 0xC2, 0x21, 0x9E, 0x56, 0xDB, 0x4B,
                    0x20, 0x59, 0x32, 0x57, 0x6A, 0x85, 0xB5, 0x83, 0xF4, 0x17, 0xDD, 0xEA,
                    0xD1, 0x63, 0xBC, 0x6C, 0xD2, 0x7A, 0x52, 0x93, 0xBB, 0x4C, 0x21, 0xBE,
                    0xBA, 0xB8, 0xF9, 0xFF, 0x9F, 0xCB, 0xED, 0x60, 0x33, 0xCD, 0xDC, 0x87,
                    0x8B, 0xC6, 0x72, 0xF6, 0x73, 0x1E, 0xEA, 0xC9, 0x85, 0x8D, 0xDE, 0xC8,
                    0x5C, 0xB6, 0xBB, 0x2E, 0x69, 0x7B, 0x01, 0x2E, 0xE4, 0xF8, 0x6D, 0x80,
                    0xF3, 0x71, 0x5E, 0xF0, 0xC2, 0x8A, 0x5E, 0xA9, 0x1D, 0xB3, 0x5A, 0x21,
                    0x39, 0x7F, 0xE3, 0xD9, 0xC5, 0x09, 0x9D, 0x7C, 0x52, 0x8B, 0xF1, 0xC1,
                    0x12, 0x41, 0x0C, 0xC3, 0x01, 0x3A, 0xC9, 0x8F, 0xF6, 0x7A, 0x59, 0x67,
                    0x8D, 0x43, 0x5D, 0xEB, 0x41, 0xBC, 0x61, 0xDF, 0x3F, 0xF3, 0xB5, 0x92,
                    0x15, 0xEE, 0xD7, 0x84, 0x0F, 0xB2, 0xE7, 0xB5, 0x3A, 0xF2, 0x6B, 0x57,
                    0xFB, 0xBD, 0xA6, 0xE0, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x36, 0xA4, 0xA4, 0x33, 0xE0, 0x22, 0x87, 0x45, 0x92, 0xF9, 0x27, 0xEB,
                    0x7E, 0xEE, 0x63, 0xFF, 0x69, 0x64, 0xCF, 0xEF, 0xDA, 0x7F, 0xFA, 0x95,
                    0xCA, 0x9E, 0xD7, 0x5B, 0xFB, 0xBD, 0x1B, 0x93, 0x25, 0x23, 0x59, 0x4F,
                    0x05, 0x87, 0x57, 0xAE, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_11, 11, expected_11);

                var static4_12 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_11.CopyTo(static4_12.AsSpan());
                var expected_12 = GetExpectedStatic4(new byte[188]
                {
                    0xF4, 0x1E, 0x77, 0xF1, 0xE9, 0x11, 0xC2, 0x21, 0x9E, 0x56, 0xDB, 0x4B,
                    0x20, 0x59, 0x32, 0x57, 0x6A, 0x85, 0xB5, 0x83, 0xF4, 0x17, 0xDD, 0xEA,
                    0xD1, 0x63, 0xBC, 0x6C, 0xC1, 0x36, 0xE0, 0x59, 0xBB, 0x4C, 0x21, 0xBE,
                    0x1A, 0xB5, 0xB3, 0x84, 0x8D, 0x0A, 0x3C, 0x5D, 0x33, 0xCD, 0xDC, 0x87,
                    0x8B, 0xC6, 0x72, 0xF6, 0x73, 0x1E, 0xEA, 0xC9, 0x85, 0x8D, 0xDE, 0xC8,
                    0x74, 0x58, 0xBE, 0x5B, 0x69, 0x7B, 0x01, 0x2E, 0xE4, 0xF8, 0x6D, 0x80,
                    0xF3, 0x71, 0x5E, 0xF0, 0xC2, 0x8A, 0x5E, 0xA9, 0x1D, 0xB3, 0x5A, 0x21,
                    0x39, 0x7F, 0xE3, 0xD9, 0x39, 0xC7, 0x4A, 0xA5, 0x52, 0x8B, 0xF1, 0xC1,
                    0x4D, 0x11, 0xC9, 0xC3, 0x01, 0x3A, 0xC9, 0x8F, 0xF6, 0x7A, 0x59, 0x67,
                    0x8D, 0x43, 0x5D, 0xEB, 0x41, 0xBC, 0x61, 0xDF, 0x3F, 0xF3, 0xB5, 0x92,
                    0x15, 0xEE, 0xD7, 0x84, 0xD3, 0x32, 0x17, 0x0A, 0x3A, 0xF2, 0x6B, 0x57,
                    0xFB, 0xBD, 0xA6, 0xE0, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x36, 0xA4, 0xA4, 0x33, 0xE0, 0x22, 0x87, 0x45, 0x92, 0xF9, 0x27, 0xEB,
                    0x10, 0x12, 0x82, 0x65, 0x69, 0x64, 0xCF, 0xEF, 0x70, 0x67, 0x1F, 0x56,
                    0x96, 0x44, 0x5A, 0x10, 0xFB, 0xBD, 0x1B, 0x93, 0x7D, 0x28, 0xFE, 0x36,
                    0x05, 0x87, 0x57, 0xAE, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_12, 12, expected_12);

                var static4_13 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_12.CopyTo(static4_13.AsSpan());
                var expected_13 = GetExpectedStatic4(new byte[188]
                {
                    0xF4, 0x1E, 0x77, 0xF1, 0xE9, 0x11, 0xC2, 0x21, 0x9E, 0x56, 0xDB, 0x4B,
                    0x76, 0x85, 0x29, 0xA8, 0x6A, 0x85, 0xB5, 0x83, 0xF4, 0x17, 0xDD, 0xEA,
                    0xD1, 0x63, 0xBC, 0x6C, 0xC1, 0x36, 0xE0, 0x59, 0xD9, 0x23, 0x07, 0xC9,
                    0x1A, 0xB5, 0xB3, 0x84, 0x8D, 0x0A, 0x3C, 0x5D, 0x33, 0xCD, 0xDC, 0x87,
                    0x8B, 0xC6, 0x72, 0xF6, 0x73, 0x1E, 0xEA, 0xC9, 0x85, 0x8D, 0xDE, 0xC8,
                    0x74, 0x58, 0xBE, 0x5B, 0x69, 0x7B, 0x01, 0x2E, 0x5E, 0xB5, 0xF2, 0xFF,
                    0xF3, 0x71, 0x5E, 0xF0, 0xF6, 0xF8, 0x5F, 0xC1, 0xD3, 0x1F, 0x0F, 0xBA,
                    0x39, 0x7F, 0xE3, 0xD9, 0x4D, 0x0B, 0x78, 0x67, 0x52, 0x8B, 0xF1, 0xC1,
                    0x4D, 0x11, 0xC9, 0xC3, 0x01, 0x3A, 0xC9, 0x8F, 0xC8, 0xAE, 0xA4, 0xAF,
                    0x30, 0xD0, 0xEB, 0x3B, 0x41, 0xBC, 0x61, 0xDF, 0x95, 0x88, 0x0F, 0x71,
                    0x15, 0xEE, 0xD7, 0x84, 0xD3, 0x32, 0x17, 0x0A, 0x93, 0x9A, 0x10, 0x18,
                    0xFB, 0xBD, 0xA6, 0xE0, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x6E, 0xCD, 0xFB, 0x5B, 0x0A, 0x3A, 0xB1, 0x09, 0x92, 0xF9, 0x27, 0xEB,
                    0x10, 0x12, 0x82, 0x65, 0x69, 0x64, 0xCF, 0xEF, 0x70, 0x67, 0x1F, 0x56,
                    0x96, 0x44, 0x5A, 0x10, 0xFB, 0xBD, 0x1B, 0x93, 0x7D, 0x28, 0xFE, 0x36,
                    0x05, 0x87, 0x57, 0xAE, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_13, 13, expected_13);

                var static4_14 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_13.CopyTo(static4_14.AsSpan());
                var expected_14 = GetExpectedStatic4(new byte[188]
                {
                    0x12, 0xBE, 0x02, 0xDB, 0xE9, 0x11, 0xC2, 0x21, 0x50, 0x50, 0xE6, 0x83,
                    0xFE, 0x18, 0x84, 0xF0, 0x6A, 0x85, 0xB5, 0x83, 0x5C, 0x5A, 0x1E, 0xBF,
                    0xD1, 0x63, 0xBC, 0x6C, 0xD9, 0x18, 0x0B, 0xD7, 0x70, 0xEA, 0x38, 0x83,
                    0x87, 0x2C, 0x56, 0x23, 0x82, 0x38, 0x00, 0x2D, 0x33, 0xCD, 0xDC, 0x87,
                    0xA4, 0x9D, 0x77, 0xC5, 0x73, 0x1E, 0xEA, 0xC9, 0x85, 0x8D, 0xDE, 0xC8,
                    0x74, 0x58, 0xBE, 0x5B, 0x63, 0x25, 0x5B, 0x6D, 0x5E, 0xB5, 0xF2, 0xFF,
                    0xF3, 0x71, 0x5E, 0xF0, 0x54, 0xF2, 0x5C, 0x8F, 0x65, 0x3F, 0x6F, 0x5D,
                    0x7B, 0x69, 0x99, 0x8B, 0x4D, 0x0B, 0x78, 0x67, 0x52, 0x8B, 0xF1, 0xC1,
                    0xEA, 0x7E, 0x95, 0xE0, 0xA1, 0x4A, 0x69, 0x6F, 0x04, 0xF6, 0x88, 0x48,
                    0x30, 0xD0, 0xEB, 0x3B, 0x41, 0xBC, 0x61, 0xDF, 0x20, 0xF0, 0xE7, 0x60,
                    0xF6, 0x7C, 0x39, 0x29, 0xD3, 0x32, 0x17, 0x0A, 0x93, 0x9A, 0x10, 0x18,
                    0x83, 0xD8, 0xA3, 0x90, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x36, 0x93, 0x59, 0x1E, 0x0A, 0x3A, 0xB1, 0x09, 0xC7, 0x9B, 0xF1, 0x38,
                    0x10, 0x12, 0x82, 0x65, 0x69, 0x64, 0xCF, 0xEF, 0x70, 0x67, 0x1F, 0x56,
                    0x96, 0x44, 0x5A, 0x10, 0xFB, 0xBD, 0x1B, 0x93, 0xEA, 0xD5, 0x39, 0x89,
                    0x05, 0x87, 0x57, 0xAE, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_14, 14, expected_14);

                var static4_15 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_14.CopyTo(static4_15.AsSpan());
                var expected_15 = GetExpectedStatic4(new byte[188]
                {
                    0x12, 0xBE, 0x02, 0xDB, 0xE9, 0x11, 0xC2, 0x21, 0x50, 0x50, 0xE6, 0x83,
                    0xFE, 0x18, 0x84, 0xF0, 0x6A, 0x85, 0xB5, 0x83, 0x5C, 0x5A, 0x1E, 0xBF,
                    0xD1, 0x63, 0xBC, 0x6C, 0xD9, 0x18, 0x0B, 0xD7, 0x24, 0x19, 0xE8, 0x93,
                    0xDF, 0x19, 0x5E, 0xCD, 0x82, 0x38, 0x00, 0x2D, 0x33, 0xCD, 0xDC, 0x87,
                    0xA4, 0x9D, 0x77, 0xC5, 0x8D, 0x16, 0xCA, 0xB9, 0x85, 0x8D, 0xDE, 0xC8,
                    0x74, 0x58, 0xBE, 0x5B, 0x63, 0x25, 0x5B, 0x6D, 0x5E, 0xB5, 0xF2, 0xFF,
                    0xF3, 0x71, 0x5E, 0xF0, 0x54, 0xF2, 0x5C, 0x8F, 0x65, 0x3F, 0x6F, 0x5D,
                    0x1E, 0xB5, 0xE5, 0x3C, 0x4D, 0x0B, 0x78, 0x67, 0x52, 0x8B, 0xF1, 0xC1,
                    0xEA, 0x7E, 0x95, 0xE0, 0xA1, 0x4A, 0x69, 0x6F, 0x04, 0xF6, 0x88, 0x48,
                    0x30, 0xD0, 0xEB, 0x3B, 0x41, 0xBC, 0x61, 0xDF, 0x20, 0xF0, 0xE7, 0x60,
                    0xF6, 0x7C, 0x39, 0x29, 0xD3, 0x32, 0x17, 0x0A, 0x93, 0x9A, 0x10, 0x18,
                    0x83, 0xD8, 0xA3, 0x90, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x36, 0x93, 0x59, 0x1E, 0x79, 0xE2, 0x74, 0x0D, 0x87, 0x30, 0xB7, 0x80,
                    0x5A, 0x80, 0xF4, 0x11, 0x69, 0x64, 0xCF, 0xEF, 0xBB, 0x71, 0xA2, 0xB1,
                    0x96, 0x44, 0x5A, 0x10, 0xFB, 0xBD, 0x1B, 0x93, 0xEA, 0xD5, 0x39, 0x89,
                    0x05, 0x87, 0x57, 0xAE, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_15, 15, expected_15);

                var static4_16 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_15.CopyTo(static4_16.AsSpan());
                var expected_16 = GetExpectedStatic4(new byte[188]
                {
                    0xBA, 0x8C, 0x41, 0xAE, 0x61, 0xC6, 0x86, 0x81, 0xA8, 0x40, 0x44, 0xE2,
                    0xFE, 0x18, 0x84, 0xF0, 0x6A, 0x85, 0xB5, 0x83, 0x5C, 0x5A, 0x1E, 0xBF,
                    0xD1, 0x63, 0xBC, 0x6C, 0xD9, 0x18, 0x0B, 0xD7, 0x24, 0x19, 0xE8, 0x93,
                    0xDF, 0x19, 0x5E, 0xCD, 0x6F, 0x32, 0x61, 0x0E, 0xFA, 0x12, 0x76, 0xA7,
                    0xA4, 0x9D, 0x77, 0xC5, 0x99, 0xB3, 0x3F, 0x01, 0x1F, 0x44, 0x8C, 0xC9,
                    0x74, 0x58, 0xBE, 0x5B, 0xE9, 0x79, 0x7A, 0x9B, 0x5E, 0xB5, 0xF2, 0xFF,
                    0x3C, 0x4F, 0xB0, 0x37, 0xBC, 0xBB, 0xD0, 0xBE, 0x65, 0x3F, 0x6F, 0x5D,
                    0xCC, 0xE3, 0xE4, 0x39, 0xDE, 0x29, 0x96, 0xB8, 0x3E, 0x47, 0x2E, 0xB8,
                    0x4E, 0x86, 0xA1, 0x4E, 0xA1, 0x4A, 0x69, 0x6F, 0x04, 0xF6, 0x88, 0x48,
                    0x30, 0xD0, 0xEB, 0x3B, 0x41, 0xBC, 0x61, 0xDF, 0x20, 0xF0, 0xE7, 0x60,
                    0x86, 0x71, 0xF1, 0x73, 0xD3, 0x32, 0x17, 0x0A, 0x47, 0x4A, 0x0C, 0x8F,
                    0x83, 0xD8, 0xA3, 0x90, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x36, 0x93, 0x59, 0x1E, 0x79, 0xE2, 0x74, 0x0D, 0x87, 0x30, 0xB7, 0x80,
                    0x5A, 0x80, 0xF4, 0x11, 0x75, 0x51, 0xE6, 0x5E, 0xBB, 0x71, 0xA2, 0xB1,
                    0x96, 0x44, 0x5A, 0x10, 0x56, 0x86, 0x28, 0xFC, 0xEA, 0xD5, 0x39, 0x89,
                    0x7C, 0xF5, 0x0D, 0x95, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_16, 16, expected_16);

                var static4_17 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_16.CopyTo(static4_17.AsSpan());
                var expected_17 = GetExpectedStatic4(new byte[188]
                {
                    0xBA, 0x8C, 0x41, 0xAE, 0x61, 0xC6, 0x86, 0x81, 0xA8, 0x40, 0x44, 0xE2,
                    0xCB, 0x2A, 0xE0, 0x15, 0x6A, 0x85, 0xB5, 0x83, 0x5C, 0x5A, 0x1E, 0xBF,
                    0xD1, 0x63, 0xBC, 0x6C, 0xD9, 0x18, 0x0B, 0xD7, 0x24, 0x19, 0xE8, 0x93,
                    0xDF, 0x19, 0x5E, 0xCD, 0x6F, 0x32, 0x61, 0x0E, 0xF3, 0x9D, 0x13, 0x7C,
                    0xA4, 0x9D, 0x77, 0xC5, 0x99, 0xB3, 0x3F, 0x01, 0x1F, 0x44, 0x8C, 0xC9,
                    0x74, 0x58, 0xBE, 0x5B, 0xE9, 0x79, 0x7A, 0x9B, 0x5E, 0xB5, 0xF2, 0xFF,
                    0x3C, 0x4F, 0xB0, 0x37, 0xBC, 0xBB, 0xD0, 0xBE, 0xB0, 0x77, 0x63, 0xE6,
                    0xCC, 0xE3, 0xE4, 0x39, 0x34, 0xDC, 0x04, 0xD3, 0x3E, 0x47, 0x2E, 0xB8,
                    0x4E, 0x86, 0xA1, 0x4E, 0xA1, 0x4A, 0x69, 0x6F, 0x04, 0xF6, 0x88, 0x48,
                    0x30, 0xD0, 0xEB, 0x3B, 0x41, 0xBC, 0x61, 0xDF, 0x20, 0xF0, 0xE7, 0x60,
                    0x86, 0x71, 0xF1, 0x73, 0xD3, 0x32, 0x17, 0x0A, 0x47, 0x4A, 0x0C, 0x8F,
                    0x83, 0xD8, 0xA3, 0x90, 0xF1, 0x87, 0x4D, 0xC9, 0xAE, 0xBD, 0xBF, 0x93,
                    0x36, 0x93, 0x59, 0x1E, 0x79, 0xE2, 0x74, 0x0D, 0xED, 0xE0, 0xD7, 0x1E,
                    0x5A, 0x80, 0xF4, 0x11, 0x75, 0x51, 0xE6, 0x5E, 0xBB, 0x71, 0xA2, 0xB1,
                    0x96, 0x44, 0x5A, 0x10, 0x56, 0x86, 0x28, 0xFC, 0xEA, 0xD5, 0x39, 0x89,
                    0x7C, 0xF5, 0x0D, 0x95, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_17, 17, expected_17);

                var static4_18 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_17.CopyTo(static4_18.AsSpan());
                var expected_18 = GetExpectedStatic4(new byte[188]
                {
                    0xBA, 0x8C, 0x41, 0xAE, 0x9B, 0x4D, 0x4A, 0x1B, 0xA8, 0x40, 0x44, 0xE2,
                    0xCB, 0x2A, 0xE0, 0x15, 0x6A, 0x85, 0xB5, 0x83, 0xF1, 0x60, 0x91, 0x9A,
                    0xD1, 0x63, 0xBC, 0x6C, 0x11, 0x9E, 0xAC, 0xC3, 0xEC, 0xC8, 0x12, 0xF5,
                    0xDF, 0x19, 0x5E, 0xCD, 0x6F, 0x32, 0x61, 0x0E, 0xF3, 0x9D, 0x13, 0x7C,
                    0x25, 0x88, 0x1D, 0xF5, 0x99, 0xB3, 0x3F, 0x01, 0x1F, 0x44, 0x8C, 0xC9,
                    0x74, 0x58, 0xBE, 0x5B, 0xE9, 0x79, 0x7A, 0x9B, 0x7E, 0xE5, 0x5E, 0x62,
                    0x3C, 0x4F, 0xB0, 0x37, 0xBC, 0xBB, 0xD0, 0xBE, 0xF0, 0x46, 0x50, 0x21,
                    0xCC, 0xE3, 0xE4, 0x39, 0x34, 0xDC, 0x04, 0xD3, 0x3E, 0x47, 0x2E, 0xB8,
                    0x4E, 0x86, 0xA1, 0x4E, 0xA1, 0x4A, 0x69, 0x6F, 0x04, 0xF6, 0x88, 0x48,
                    0x30, 0xD0, 0xEB, 0x3B, 0xED, 0x9E, 0x05, 0x26, 0x94, 0x20, 0x5C, 0x1A,
                    0x86, 0x71, 0xF1, 0x73, 0xD3, 0x32, 0x17, 0x0A, 0x47, 0x4A, 0x0C, 0x8F,
                    0xE9, 0x16, 0x26, 0xCD, 0x47, 0x8F, 0x34, 0x0F, 0x98, 0x45, 0xF7, 0x93,
                    0x36, 0x93, 0x59, 0x1E, 0x79, 0xE2, 0x74, 0x0D, 0xCD, 0x88, 0xA7, 0x8B,
                    0x5A, 0x80, 0xF4, 0x11, 0x23, 0x59, 0xE1, 0x34, 0xBB, 0x71, 0xA2, 0xB1,
                    0x96, 0x44, 0x5A, 0x10, 0x72, 0xCB, 0x47, 0x13, 0x03, 0x81, 0xB1, 0x12,
                    0xB7, 0xFC, 0x24, 0x2E, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_18, 18, expected_18);

                var static4_19 = new uint[FingerprintConsts.BigContextLengthDword];
                expected_18.CopyTo(static4_19.AsSpan());
                var expected_19 = GetExpectedStatic4(new byte[188]
                {
                    0xBA, 0x8C, 0x41, 0xAE, 0x9B, 0x4D, 0x4A, 0x1B, 0xA8, 0x40, 0x44, 0xE2,
                    0xCB, 0x2A, 0xE0, 0x15, 0x6A, 0x85, 0xB5, 0x83, 0xF1, 0x60, 0x91, 0x9A,
                    0xD1, 0x63, 0xBC, 0x6C, 0x11, 0x9E, 0xAC, 0xC3, 0xEC, 0xC8, 0x12, 0xF5,
                    0xDF, 0x19, 0x5E, 0xCD, 0x6F, 0x32, 0x61, 0x0E, 0xF3, 0x9D, 0x13, 0x7C,
                    0x25, 0x88, 0x1D, 0xF5, 0x99, 0xB3, 0x3F, 0x01, 0x1F, 0x44, 0x8C, 0xC9,
                    0x74, 0x58, 0xBE, 0x5B, 0xE9, 0x79, 0x7A, 0x9B, 0x7E, 0xE5, 0x5E, 0x62,
                    0x3C, 0x4F, 0xB0, 0x37, 0xBC, 0xBB, 0xD0, 0xBE, 0xF0, 0x46, 0x50, 0x21,
                    0xCC, 0xE3, 0xE4, 0x39, 0x34, 0xDC, 0x04, 0xD3, 0x3E, 0x47, 0x2E, 0xB8,
                    0x4E, 0x86, 0xA1, 0x4E, 0x08, 0x42, 0x9D, 0x6A, 0x04, 0xF6, 0x88, 0x48,
                    0x30, 0xD0, 0xEB, 0x3B, 0xED, 0x9E, 0x05, 0x26, 0x94, 0x20, 0x5C, 0x1A,
                    0x86, 0x71, 0xF1, 0x73, 0xD3, 0x32, 0x17, 0x0A, 0x47, 0x4A, 0x0C, 0x8F,
                    0xE9, 0x16, 0x26, 0xCD, 0x47, 0x8F, 0x34, 0x0F, 0x98, 0x45, 0xF7, 0x93,
                    0x36, 0x93, 0x59, 0x1E, 0x79, 0xE2, 0x74, 0x0D, 0xCD, 0x88, 0xA7, 0x8B,
                    0x5A, 0x80, 0xF4, 0x11, 0xE7, 0x82, 0x52, 0x1F, 0xF1, 0xF0, 0x60, 0xA9,
                    0x96, 0x44, 0x5A, 0x10, 0x72, 0xCB, 0x47, 0x13, 0x03, 0x81, 0xB1, 0x12,
                    0xB7, 0xFC, 0x24, 0x2E, 0x03, 0x7F, 0xF4, 0xF3,
                });
                yield return new TestCaseData(static4_19, 19, expected_19);
            }
        }
    
    [Test]
    [TestCaseSource(nameof(MutateStatic4TestCases))]
    public void MutateContext(uint[] static4, int mutateIndex, uint[] expectedStatic4)
    {
        ContextMutator.Mutate(static4, mutateIndex);
        Assert.That(expectedStatic4.SequenceEqual(static4));
    }
    
    private static uint[] GetExpectedStatic4(byte[] hxdPaste) => MemoryMarshal.Cast<byte, uint>(hxdPaste).ToArray();
}