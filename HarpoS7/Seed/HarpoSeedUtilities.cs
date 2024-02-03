using System.Runtime.InteropServices;
using CommunityToolkit.HighPerformance.Buffers;
using HarpoS7.Aes;
using HarpoS7.Extensions;
using HarpoS7.Keys;

namespace HarpoS7.Seed;

public class HarpoSeedUtilities
{
    public static void GenerateEncryptedSeed(Span<byte> destination, ReadOnlySpan<byte> publicKey,
        ReadOnlySpan<byte> challengeEncryptionKey)
    {
        Span<byte> startBytes = stackalloc byte[72];
        Span<byte> aesKeyAndIv = stackalloc byte[48];

        if (OmsReverseRows(startBytes, publicKey, publicKey[32..]) == 0)
        {
            Span<byte> l1 = stackalloc byte[32];
            Span<byte> v3 = stackalloc byte[72];
            Span<byte> v4 = stackalloc byte[72];

            do
            {
                l1.FillWithCryptoRandomBytes();
                l1.Reverse();

                SeedFunction2(v3, SeedConsts.Seed1.Span, l1, 4);
                SeedFunction2(v4, startBytes, l1, 4);
            } while (v3.AsDwords()[16] == 1 || v4.AsDwords()[16] == 1 || ZeroCheck32(v4));

            v3[..32].ReverseBytes(destination);
            v3.Slice(32, 32).ReverseBytes(destination[32..]);

            KeyUtilities.DeriveSeedEncryptionKeyAndIv(aesKeyAndIv, v4, destination);

            // we are using AES-128, so the key size is 128 bit (16 bytes).
            // the rest of the derived bytes are discarded
            using HarpoAesCtr aes = new(aesKeyAndIv[..16]);
            aes.Init(aesKeyAndIv[32..]);
            aes.EncryptCtr(challengeEncryptionKey[..16], destination[64..]);
            aes.CalculateChecksum(destination.Slice(80, 16));
        }
    }

    /// <summary>
    /// Reverses 32 bytes from data1 and puts them at destination
    /// and then does the same to data2, but puts the data at destination offset 32
    /// <para>
    /// Destination: reverse(take32Bytes(data1)) + reverse(take32Bytes(data2))
    /// </para>
    /// </summary>
    /// <param name="destination">Where to write the data (must be at least 72 bytes)</param>
    /// <param name="a2">Sets the dword at destination offset 64 to this value</param>
    /// <param name="data1">First part of data (must be at least 32 bytes)</param>
    /// <param name="data2">Second part of data (must be at least 32 bytes)</param>
    /// <returns>1 if a2 is not 0 and is not 1, 0 if successful and 3 when the either of the parts were all zeros</returns>
    internal static int OmsReverseRows(Span<byte> destination, ReadOnlySpan<byte> data1, ReadOnlySpan<byte> data2,
        int a2 = 0)
    {
        if (a2 != 0 && a2 != 1)
        {
            return 1;
        }

        destination.AsDwords()[16] = (uint)a2;

        var dstQword = destination.AsQwords();
        var data1Qword = data1.AsQwords();
        var data2Qword = data2.AsQwords();

        //data1Qword.ReverseBytes(dstQword[..32]);
        //data2Qword.ReverseBytes(dstQword.Slice(32, 32));

        data1[..32].ReverseBytes(destination[..32]);
        data2[..32].ReverseBytes(destination.Slice(32, 32));

        if (!ZeroCheck64(destination))
        {
            // PubKeyOp3 gets called here but i could not be bothered
            // it'd really simple to implement - only the so far reversed functions
            // are used but I do not see the point for now
            // 0 is the right return value
            return 0;
        }

        return 3;
    }

    internal static void SeedFunction4(Span<byte> a1, Span<byte> a2, Span<byte> a3,
        ReadOnlySpan<byte> a4, ReadOnlySpan<byte> a5, ReadOnlySpan<byte> a6,
        ReadOnlySpan<byte> a7, ReadOnlySpan<byte> a8, Span<byte> a9)
    {
        var a9Qword = a9.AsQwords();

        SeedMask(a9, a6);
        if (!ZeroCheck32(a6))
        {
            PubKeyOp4(a9, a6);

            var v1Span = a9Qword[12..].AsBytes();
            PubKeyOp12(v1Span, a9, a7);

            var v2Span = a9Qword[4..].AsBytes();
            SeedMask(v2Span, a4);
            SeedMask(v1Span, v1Span);

            if (SeedMaskSub2(v1Span, v2Span, 4) == 0)
            {
                PubKeyOp12(v1Span, a6, a9);
                PubKeyOp12(v1Span, v1Span, a8);
                SeedMask(v2Span, a5);
                SeedMask(v1Span, v1Span);

                if (SeedMaskSub2(v1Span, v2Span, 4) == 0)
                {
                    SeedFunction3(a1, a2, a3, a4, a5, a6, a9);
                }
                else
                {
                    a3.AsQwords()[..4].Clear();
                }
            }
            else
            {
                PubKeyOp12(v2Span, a9, a6);
                PubKeyOp12(v2Span, v2Span, a8);
                PubKeyOp15(a9, v1Span, a4);
                PubKeyOp15(v2Span, v2Span, a5);
                PubKeyOp12(a3, a6, a9);
                PubKeyOp4(v1Span, a9);

                var v3Span = a9Qword[8..].AsBytes();
                PubKeyOp12(v3Span, a4, v1Span);
                PubKeyOp12(a1, a9, v1Span);
                PubKeyOp12(a2, a5, a1);

                PubKeyOp16(a1, a1, v3Span);
                PubKeyOp16(a1, a1, v3Span);

                PubKeyOp4(a9, v2Span);

                PubKeyOp15(a1, a9, a1);
                PubKeyOp15(a9, v3Span, a1);

                PubKeyOp12(a9, v2Span, a9);

                PubKeyOp15(a2, a9, a2);
            }
        }
        else
        {
            a7.AsQwords()[..4].CopyTo(a1.AsQwords());
            a8.AsQwords()[..4].CopyTo(a2.AsQwords());
            a3.AsQwords()[..4].Clear();
            a3.AsQwords()[0] = 1UL;
        }
    }

    internal static void SeedFunction3(Span<byte> a1, Span<byte> a2, Span<byte> a3,
        ReadOnlySpan<byte> a4, ReadOnlySpan<byte> a5, ReadOnlySpan<byte> a6,
        Span<byte> a7)
    {
        SeedMask(a7, a6);

        var v1Span = a7.AsQwords()[4..].AsBytes();
        SeedMask(v1Span, a5);

        if (!ZeroCheck32(a7) && !ZeroCheck32(v1Span))
        {
            var v2Span = a7.AsQwords()[8..].AsBytes();
            PubKeyOp4(v2Span, a6);
            PubKeyOp4(v1Span, v2Span);

            PubKeyOp12(v1Span, SeedConsts.Mask3.Span, v1Span);

            PubKeyOp4(a7, a4);

            var v3Span = a7.AsQwords()[12..].AsBytes();
            PubKeyOp16(v3Span, a7, a7);
            PubKeyOp16(a7, v3Span, a7);
            PubKeyOp16(a7, a7, v1Span);

            PubKeyOp12(a3, a5, a6);

            PubKeyOp16(a3, a3, a3);

            PubKeyOp4(v2Span, a5);

            PubKeyOp12(a2, v2Span, v2Span);

            for (int i = 0; i < 3; ++i)
            {
                PubKeyOp16(a2, a2, a2);
            }

            PubKeyOp12(v2Span, v2Span, a4);

            for (int i = 0; i < 2; ++i)
            {
                PubKeyOp16(v2Span, v2Span, v2Span);
            }

            PubKeyOp4(v1Span, a7);

            PubKeyOp15(a1, v1Span, v2Span);
            PubKeyOp15(a1, a1, v2Span);
            PubKeyOp15(v1Span, v2Span, a1);

            PubKeyOp12(v1Span, a7, v1Span);

            PubKeyOp15(a2, v1Span, a2);
        }
        else
        {
            a3.AsQwords()[..4].Clear();
        }
    }

    internal static void SeedFunction5(Span<byte> a1, ReadOnlySpan<byte> a2, ReadOnlySpan<byte> a3,
        ReadOnlySpan<byte> a4)
    {
        // we do not do any arithmetics, or operations ourselves, so we just rent bytes instead of qwords
        Span<byte> v1 = stackalloc byte[4 * sizeof(ulong)];

        SeedMask(v1, a4);
        if (!ZeroCheck32(v1))
        {
            var v2Span = a1.AsQwords()[4..].AsBytes();
            PubKeyOp12(v2Span, a3, v1);
            PubKeyOp17(v1, SeedConsts.Mask4.Span, v1, SeedConsts.Mask.Span);
            PubKeyOp4(v1, v1);
            PubKeyOp12(a1, v1, a2);
            PubKeyOp4(v1, v1);
            PubKeyOp12(v2Span, v1, v2Span);

            a1.AsQwords()[8] = 0;
            SeedMask(a1, a1);
            SeedMask(v2Span, v2Span);
        }
        else
        {
            a1.AsQwords()[8] = 0;
        }
    }

    internal static void SeedFunction2(Span<byte> a1, ReadOnlySpan<byte> a2, ReadOnlySpan<byte> a3, int a4)
    {
        if (a2.AsDwords()[16] == 1)
        {
            a1.AsDwords()[16] = 1;
        }
        else
        {
            Span<ulong> v1Qword = stackalloc ulong[4];
            Span<ulong> v2Qword = stackalloc ulong[4];
            Span<ulong> v3Qword = stackalloc ulong[4];
            Span<ulong> v4Qword = stackalloc ulong[16];

            var v1 = v1Qword.AsBytes();
            var v2 = v2Qword.AsBytes();
            var v3 = v3Qword.AsBytes();
            var v4 = v4Qword.AsBytes();

            const ulong mask64SignBit = (1UL << 63);

            ulong mask1 = mask64SignBit;
            var a3Qword = a3.AsQwords();

            int v10 = 0x3F;
            if (--a4 > -1)
            {
                ulong mask = mask1;

                int v8 = a4;
                do
                {
                    if ((a3Qword[v8] & mask1) == 0)
                    {
                        mask1 = mask >> 1;
                        mask = mask1;

                        if (--v10 > -1)
                        {
                            continue;
                        }
                    }

                    if (v10 > -1)
                    {
                        break;
                    }

                    a4--;
                    v8--;

                    mask1 = mask64SignBit;
                    v10 = 0x3F;
                    mask = mask1;
                } while (v8 > -1);
            }

            if (a4 > -1)
            {
                int index = a4;
                do
                {
                    if (v10 > -1)
                    {
                        for (int i = v10; i >= 0; --i)
                        {
                            SeedFunction3(v2, v3, v1, v2, v3, v1, v4);
                            if ((a3Qword[index] & mask1) != 0)
                            {
                                SeedFunction4(v2, v3, v1, v2, v3, v1, a2, a2[0x20..], v4);
                            }

                            mask1 >>= 1;
                        }
                    }

                    index--;
                    v10 = 0x3F;
                    mask1 = mask64SignBit;
                } while (index + 1 > 0);
            }

            SeedFunction5(a1, v2, v3, v1);
        }
    }

    internal static void PubKeyOp4(Span<byte> destination, ReadOnlySpan<byte> a2)
    {
        if (destination.Length < 32)
        {
            throw new ArgumentException("Destination must be at least 32 bytes long", nameof(destination));
        }

        if (a2.Length < 32)
        {
            throw new ArgumentException("A2 must be at least 32 bytes long", nameof(a2));
        }

        Span<ulong> destQword = MemoryMarshal.Cast<byte, ulong>(destination);
        ReadOnlySpan<ulong> a2Qword = MemoryMarshal.Cast<byte, ulong>(a2);

        Span<byte> v1 = new byte[0x48];
        Span<ulong> v1Qword = MemoryMarshal.Cast<byte, ulong>(v1);

        int v1ReadIndex = 1;
        int v1WriteIndex = 4;
        int a2Index = 0;
        int v3 = 0;
        do
        {
            ulong t1 = a2Qword[a2Index];
            ulong v2 = PubKeyOp5(v1Qword[v1ReadIndex..], t1, a2Qword[(a2Index + 1)..], 0UL, 3 - (v3++));

            a2Index += 1;

            v1ReadIndex += 2;
            v1Qword[v1WriteIndex++] = v2;
        } while (v3 < 3);

        v1Qword[7] = v1Qword[6] >> 0x3F;
        int index = 6;
        v1ReadIndex = 5;
        v1WriteIndex = 6;
        do
        {
            ulong v4 = v1Qword[v1ReadIndex--];
            v1Qword[v1WriteIndex] = (v1Qword[v1WriteIndex--] * 2) | (v4 >> 0x3F);
        } while (--index > 0);

        ulong v5 = 0UL;
        v1WriteIndex = 1;
        a2Index = 0;
        index = 4;
        do
        {
            ulong v6 = PubKeyOp5(v1Qword[(v1WriteIndex - 1)..], a2Qword[a2Index], a2Qword[(a2Index++)..], v5, 1);
            v1Qword[v1WriteIndex] += v6;

            v5 = (v1Qword[v1WriteIndex] < v6 ? 1UL : 0UL); // overflow check

            v1WriteIndex += 2;
        } while (--index > 0);

        PubKeyOp6(destination, v1);
    }

    internal static void PubKeyOp6(Span<byte> destination, ReadOnlySpan<byte> a2)
    {
        Span<byte> l1 = stackalloc byte[4 * sizeof(ulong)];
        Span<byte> l2 = stackalloc byte[4 * sizeof(ulong)];

        var l1Qword = MemoryMarshal.Cast<byte, ulong>(l1);
        var l2Qword = MemoryMarshal.Cast<byte, ulong>(l2);

        var a2Qword = MemoryMarshal.Cast<byte, ulong>(a2);

        PubKeyOp7(l1, a2, 0x0F, 0x0E, 0x0D, 0x0C, 0x0B, 0x00, 0x00, 0x00);
        PubKeyOp7(l2, a2, 0x00, 0x0F, 0x0E, 0x0D, 0x0C, 0x00, 0x00, 0x00);
        var l4 = PubKeyOp8(l1, l1, l2);

        a2Qword[..4].CopyTo(l2Qword);
        //l2Qword[0] = a2[0];
        //l2Qword[1] = a2[1];
        //l2Qword[2] = a2[2];
        //l2Qword[3] = a2[3];

        int l5 = l4 != 0 ? 2 : 0;

        uint l6 = 0;
        for (int i = 0; i < 4; ++i)
        {
            ulong t1 = l1Qword[i];
            l1Qword[i] = (t1 * 2) | l6;
            l6 = (t1 & 0x8000000000000000) != 0 ? 1U : 0U;
        }

        l4 = PubKeyOp8(l2, l2, l1);
        PubKeyOp7(l1, a2, 0x0F, 0x0E, 0x00, 0x00, 0x00, 0x0A, 0x09, 0x08);

        var l11 = PubKeyOp8(l2, l2, l1);
        PubKeyOp7(l1, a2, 0x08, 0x0D, 0x0F, 0x0E, 0x0D, 0x0B, 0x0A, 0x09);

        var l7 = PubKeyOp8(l2, l2, l1);
        PubKeyOp7(l1, a2, 0x0A, 0x08, 0x00, 0x00, 0x00, 0x0D, 0x0C, 0x0B);

        var l8 = PubKeyOp9(l2, l2, l1, 0);
        PubKeyOp7(l1, a2, 0x0B, 0x09, 0x00, 0x00, 0x0F, 0x0E, 0x0D, 0x0C);

        var l9 = PubKeyOp9(l2, l2, l1, 0);
        PubKeyOp7(l1, a2, 0x0C, 0x00, 0x0A, 0x09, 0x08, 0x0F, 0x0E, 0x0D);

        var l10 = PubKeyOp9(l2, l2, l1, 0);
        PubKeyOp7(l1, a2, 0x0D, 0x00, 0x0B, 0x0A, 0x09, 0x00, 0x0F, 0x0E);

        var l12 = PubKeyOp9(destination, l2, l1, 0);

        l5 = (int)(((((l5 + l4 + l6 + l11 + l7) - l8) - l9) - l10) - l12);
        if (l5 != 0)
        {
            long t2 = -l5;
            if (l5 > 0)
            {
                t2 = l5;
            }

            if (l5 < 1)
            {
                l4 = PubKeyOp9(destination, destination, SeedConsts.Mask2.Span[((int)(t2 - 1) * 0x20)..], 0);
            }
            else
            {
                l4 = PubKeyOp8(destination, destination, SeedConsts.Mask2.Span[((int)(t2 - 1) * 0x20)..]);
            }

            l5 = (int)-l4;

            if (l5 != 0)
            {
                if (l5 < 1)
                {
                    PubKeyOp9(destination, destination, SeedConsts.Mask2.Span, 0);
                }
                else
                {
                    PubKeyOp8(destination, destination, SeedConsts.Mask2.Span);
                }
            }
        }

        l5 = (int)SeedMaskSub2(destination, SeedConsts.Mask.Span, 4);
        if (l5 > -1)
        {
            PubKeyOp9(destination, destination, SeedConsts.Mask.Span, 0);
        }
    }

    internal static void PubKeyOp7(Span<byte> a1, ReadOnlySpan<byte> a2,
        uint a3 = 0, uint a4 = 0, uint a5 = 0, uint a6 = 0, uint a7 = 0, uint a8 = 0, uint a9 = 0, uint a10 = 0)
    {
        if (a1.Length < sizeof(ulong) * 4)
        {
            throw new ArgumentException($"A1 must be at least {sizeof(ulong) * 4} bytes long", nameof(a1));
        }

        Span<ulong> a1Qword = MemoryMarshal.Cast<byte, ulong>(a1);
        ReadOnlySpan<uint> a2Dword = MemoryMarshal.Cast<byte, uint>(a2);

        a1Qword[..4].Clear();

        Op7Math(a1Qword[3..], a2Dword, a3, shiftLeft20Bytes: true);
        Op7Math(a1Qword[3..], a2Dword, a4, shiftLeft20Bytes: false);

        Op7Math(a1Qword[2..], a2Dword, a5, shiftLeft20Bytes: true);
        Op7Math(a1Qword[2..], a2Dword, a6, shiftLeft20Bytes: false);

        Op7Math(a1Qword[1..], a2Dword, a7, shiftLeft20Bytes: true);
        Op7Math(a1Qword[1..], a2Dword, a8, shiftLeft20Bytes: false);

        Op7Math(a1Qword, a2Dword, a9, shiftLeft20Bytes: true);
        Op7Math(a1Qword, a2Dword, a10, shiftLeft20Bytes: false);
    }

    private static void Op7Math(Span<ulong> a1, ReadOnlySpan<uint> a2, uint constVar, bool shiftLeft20Bytes)
    {
        if (constVar != 0)
        {
            ulong t1;
            if ((constVar & 1) == 0)
            {
                t1 = a2[(int)((constVar >> 1) * 2)];
            }
            else
            {
                var a2Qword = MemoryMarshal.Cast<uint, ulong>(a2);
                t1 = a2Qword[(int)((constVar >> 1))] >> 0x20;
            }

            a1[0] |= shiftLeft20Bytes ? (t1 << 0x20) : t1;
        }
    }

    internal static uint PubKeyOp8(Span<byte> a1, Span<byte> a2, ReadOnlySpan<byte> a3)
    {
        Span<ulong> a1Qword = MemoryMarshal.Cast<byte, ulong>(a1);
        Span<ulong> a2Qword = MemoryMarshal.Cast<byte, ulong>(a2);
        ReadOnlySpan<ulong> a3Qword = MemoryMarshal.Cast<byte, ulong>(a3);

        ulong t1 = a2Qword[0];
        ulong v1 = a3Qword[0] + t1;
        a1Qword[0] = v1;

        // when a sum is smaller than one of the addends, it means that the sum overflow the ulong
        uint of = t1 > v1 ? 1U : 0U;
        int index = 1;
        do
        {
            ulong v2 = a2Qword[index];
            ulong v3 = a3Qword[index];
            ulong v4 = v3 + of + v2;
            a1Qword[index++] = v4;

            of = (((v3 + of) < of) || v4 < v2) ? 1U : 0U;
        } while (index <= 3);

        return of;
    }

    internal static uint PubKeyOp9(Span<byte> a1, ReadOnlySpan<byte> a2, ReadOnlySpan<byte> a3, int a4)
    {
        Span<ulong> a1Qword = MemoryMarshal.Cast<byte, ulong>(a1);
        ReadOnlySpan<ulong> a2Qword = MemoryMarshal.Cast<byte, ulong>(a2);
        ReadOnlySpan<long> a3Qword = MemoryMarshal.Cast<byte, long>(a3);

        // do not inline, a1 and a2 are very often (if not always) the same span. Inlining results in breaking v2
        ulong t1 = a2Qword[0];
        ulong v1 = t1 - (ulong)a3Qword[0];
        a1Qword[0] = v1;

        ulong v2 = (t1 < v1 ? 1U : 0U);
        int index = 1;
        do
        {
            ulong v3 = a2Qword[index];
            v2 = v3 - v2;
            ulong v4 = (ulong)a3Qword[index];

            a1Qword[index] = v2 - v4;

            v2 = (v3 < v2 || v2 < (v2 - v4)) ? 1UL : 0UL;
        } while (++index <= 3);

        if (a4 != 0)
        {
            index = 5;
            do
            {
                ulong v5 = a2Qword[index];
                ulong v6 = (ulong)a3Qword[index];
                v2 = v5 - v2;
                a1Qword[index] = v2 - v6;

                v2 = (v5 < v2 || v2 < (v2 - v6)) ? 1UL : 0UL;
            } while ((index++ - 3) < a4);
        }

        return (uint)v2;
    }

    internal static uint SeedMaskSub2(ReadOnlySpan<byte> a1, ReadOnlySpan<byte> mask, int size)
    {
        if (size == 0) return 0;

        ReadOnlySpan<ulong> a1Qword = MemoryMarshal.Cast<byte, ulong>(a1);
        ReadOnlySpan<ulong> maskQword = MemoryMarshal.Cast<byte, ulong>(mask);
        if (--size > 0)
        {
            do
            {
                if (a1Qword[size] != maskQword[size])
                {
                    break;
                }
            } while (--size > 0);
        }

        if (a1Qword[size] > maskQword[size])
        {
            return 1;
        }

        return (uint)(-(maskQword[size] > a1Qword[size] ? 1 : 0));
    }

    internal static ulong PubKeyOp5(Span<ulong> output, ulong a2, ReadOnlySpan<ulong> data, ulong a4, int size)
    {
        ulong v3;
        ulong v5;
        ulong v4;
        int v2;
        uint v1;
        ulong v6;
        ulong v7;

        v1 = 0;
        if (size != 0)
        {
            v2 = 0;
            do
            {
                v3 = data[v2] & 0xffffffff;
                v4 = data[v2] >> 0x20;
                v5 = v3 * (a2 >> 0x20);
                v6 = v3 * (a2 & 0xffffffff) + a4;
                v3 = v4 * (a2 & 0xffffffff) + v5;
                v7 = v6 + (v3 << 0x20);
                output[v2] = output[v2] + v7;

                long t1 = v3 < v5 ? 1 : 0;
                ulong t2 = v6 < a4 ? 1UL : 0UL;
                ulong t3 = output[v2] < v7 ? 1UL : 0UL;
                ulong t4 = v7 < (v3 << 0x20) ? 1UL : 0UL;

                a4 = ((ulong)(-t1) & 0x100000000) + t2 +
                     v4 * (a2 >> 0x20) + (v3 >> 0x20) + t3 + t4;
                v1++;
                v2 = (int)v1;
            } while (v2 < size);
        }

        return a4;
    }

    /// <summary>
    /// Checks whether any of the 8 DWORDs passed in are not zero 
    /// </summary>
    /// <param name="data">The data to check, must be at least 32 bytes long (must contain at least 8 DWORDs)</param>
    /// <returns>false when any of the DWORDs are NOT 0, true when all of the DWORDs are zero</returns>
    /// <exception cref="ArgumentException">Thrown when the data is less than 32 byte long</exception>
    internal static bool ZeroCheck32(ReadOnlySpan<byte> data)
    {
        if (data.Length < 8 * sizeof(uint))
        {
            throw new ArgumentException("Data must be at least 32 bytes long", nameof(data));
        }

        var dwordData = MemoryMarshal.Cast<byte, uint>(data);
        for (int i = 0; i < 4; ++i)
        {
            if ((dwordData[i * 2] | dwordData[i * 2 + 1]) != 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Checks whether any of the 16 DWORDs (64 bytes) passed in are not zero 
    /// </summary>
    /// <param name="data">The data to check, must be at least 64 bytes long (must contain at least 16 DWORDs)</param>
    /// <returns>false when any of the DWORDs are NOT 0, true when all of the DWORDs are zero</returns>
    /// <exception cref="ArgumentException">Thrown when the data is less than 64 byte long</exception>
    internal static bool ZeroCheck64(ReadOnlySpan<byte> data)
    {
        if (data.Length < 16 * sizeof(uint))
        {
            throw new ArgumentException("Data must be at least 64 bytes long", nameof(data));
        }

        var dataQword = MemoryMarshal.Cast<byte, ulong>(data);
        for (int i = 0; i < 8; ++i)
        {
            if (dataQword[i] != 0)
            {
                return false;
            }
        }

        return true;
    }

    internal static void SeedMask(Span<byte> destination, ReadOnlySpan<byte> a2)
    {
        if (destination.Length < 32)
        {
            throw new ArgumentException("Destination must be at least 32 bytes long", nameof(destination));
        }

        if (a2.Length < 32)
        {
            throw new ArgumentException("Second argument must be at least 32 bytes long", nameof(a2));
        }

        var destQword = MemoryMarshal.Cast<byte, ulong>(destination);
        var a2Qword = MemoryMarshal.Cast<byte, ulong>(a2);

        if (!destination.Overlaps(a2))
        {
            a2Qword[..4].CopyTo(destQword);
        }

        int v1 = (int)SeedMaskSub2(destination, SeedConsts.Mask.Span, 4);
        while (v1 > -1)
        {
            PubKeyOp9(destination, destination, SeedConsts.Mask.Span, 0);
            v1 = (int)SeedMaskSub2(destination, SeedConsts.Mask.Span, 4);
        }
    }

    internal static void PubKeyOp12(Span<byte> destination, ReadOnlySpan<byte> a2, ReadOnlySpan<byte> a3)
    {
        Span<ulong> v1 = stackalloc ulong[10];

        var a2Qword = MemoryMarshal.Cast<byte, ulong>(a2);
        var a3Qword = MemoryMarshal.Cast<byte, ulong>(a3);

        v1.Clear();

        for (int i = 0; i < 4; ++i)
        {
            var v2 = PubKeyOp5(v1[i..], a2Qword[i], a3Qword, 0, 4);
            v1[i + 4] = v2;
        }

        PubKeyOp6(destination, MemoryMarshal.Cast<ulong, byte>(v1));
    }

    internal static void PubKeyOp16(Span<byte> destination, Span<byte> a2, ReadOnlySpan<byte> a3)
    {
        var v1 = PubKeyOp8(destination, a2, a3);
        if (v1 != 0 || (int)SeedMaskSub2(destination, SeedConsts.Mask.Span, 4) > -1)
        {
            PubKeyOp9(destination, destination, SeedConsts.Mask.Span, 0);
        }
    }

    internal static void PubKeyOp15(Span<byte> destination, Span<byte> a2, ReadOnlySpan<byte> a3)
    {
        var v1 = PubKeyOp9(destination, a2, a3, 0);
        if (v1 != 0)
        {
            PubKeyOp8(destination, destination, SeedConsts.Mask.Span);
        }
    }

    internal static void PubKeyOp19(Span<byte> destination, ulong a2)
    {
        var destQword = destination.AsQwords();

        for (int i = 0; i < 3; ++i)
        {
            destQword[i] = (destQword[i + 1] << 0x3F) | (destQword[i] >> 1);
        }

        destQword[3] = (destQword[3] >> 1) | (a2 << 0x3F);
    }

    internal static void PubKeyOp18(Span<byte> destination, Span<byte> a2, ReadOnlySpan<byte> a3)
    {
        // insane, actually using a single byte and not ulong or uint
        var v1 = destination[0];

        while ((v1 & 0x01) == 0x00)
        {
            PubKeyOp19(destination, 0);

            uint v2 = 0;
            if ((a2[0] & 1) != 0x00)
            {
                v2 = PubKeyOp8(a2, a2, a3);
            }

            PubKeyOp19(a2, v2);
            v1 = destination[0];
        }
    }

    internal static void PubKeyOp17(Span<byte> a1, ReadOnlySpan<byte> mask1, ReadOnlySpan<byte> a3,
        ReadOnlySpan<byte> mask2)
    {
        Span<uint> v1Dword = stackalloc uint[8];
        Span<uint> v2Dword = stackalloc uint[8];
        Span<uint> v3Dword = stackalloc uint[8];
        Span<uint> v4Dword = stackalloc uint[8];

        var v1 = v1Dword.AsBytes();
        var v2 = v2Dword.AsBytes();
        var v3 = v3Dword.AsBytes();
        var v4 = v4Dword.AsBytes();

        a3[..32].CopyTo(v2);
        mask2[..32].CopyTo(v3);
        mask1[..32].CopyTo(v1);
        v4Dword.Clear();

        if ((int)SeedMaskSub2(v2, mask2, 4) > -1)
        {
            PubKeyOp9(v2, v2, mask2, 0);
        }

        if ((int)SeedMaskSub2(v1, mask2, 4) > -1)
        {
            PubKeyOp9(v1, v1, mask2, 0);
        }

        PubKeyOp18(v2, v1, mask2);

        Span<byte> v5 = v3;
        Span<byte> v6 = v1;
        Span<byte> v10 = v4;
        Span<byte> v11 = v2;
        Span<byte> v8 = v3;

        while (!ZeroCheck32(v8))
        {
            PubKeyOp18(v5, v10, mask2);

            v8 = v5;
            Span<byte> v9 = v6;

            if ((int)SeedMaskSub2(v11, v5, 4) > 0)
            {
                v8 = v11;
                v9 = v10;
                v10 = v6;
                v11 = v5;
            }

            PubKeyOp9(v8, v8, v11, 0);
            if (PubKeyOp9(v10, v10, v9, 0) != 0)
            {
                PubKeyOp8(v10, v10, mask2);
            }

            v5 = v8;
            v6 = v9;
        }

        v6[..32].CopyTo(a1);
    }
}