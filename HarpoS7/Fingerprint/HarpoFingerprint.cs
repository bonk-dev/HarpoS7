using CommunityToolkit.HighPerformance;

namespace HarpoS7.Fingerprint;

public class HarpoFingerprint
{
    public static void FingerprintChallenge(Span<byte> fingerprintDestination, ReadOnlySpan<byte> challenge)
    {
        if (fingerprintDestination.Length < FingerprintConsts.FingerprintLength)
        {
            throw new ArgumentException("Fingerprint destination must be at least 8 bytes long",
                nameof(fingerprintDestination));
        }

        if (challenge.Length < 18)
        {
            throw new ArgumentException(
                "Challenge must be at least 18 bytes long (pass in the original, unmodified challenge)",
                nameof(challenge));
        }

        Span<byte> smallContext = stackalloc byte[FingerprintConsts.SmallContextLength];
        smallContext.Clear();
        Span<uint> bigContext = stackalloc uint[FingerprintConsts.BigContextLengthDword];
        bigContext.Clear();

        InitializeContexts(smallContext, bigContext, challenge);

        for (int i = 0; i < FingerprintConsts.NumberOfMutations; ++i)
        {
            FingerprintSubProcedure(
                FingerprintConsts.Data1Collection[i],
                FingerprintConsts.XorMagic[i],
                FingerprintConsts.Data2Collection[i],
                smallContext, bigContext);

            ContextMutator.Mutate(bigContext, i);
        }

        FinalFingerprint(fingerprintDestination, smallContext);
    }

    internal static void FinalFingerprint(Span<byte> fingerprint, ReadOnlySpan<byte> smallContext)
    {
        fingerprint[0] = (byte)((smallContext[93] << 4) | (smallContext[224] >> 4));
        fingerprint[1] =
            (byte)((((fingerprint[1] ^ smallContext[189]) & 0xf ^ smallContext[189]) ^ smallContext[53]) & 0xF ^
                   ((fingerprint[1] ^ smallContext[189]) & 0xf ^ smallContext[189]));
        fingerprint[2] = (byte)(((fingerprint[2] & 0xf | smallContext[119] << 4) ^ smallContext[86]) & 0xF ^
                                (fingerprint[2] & 0xf | smallContext[119] << 4));
        fingerprint[3] = (byte)(((fingerprint[3] ^ smallContext[83]) & 0xf ^ smallContext[83]) & 0xF0 |
                                (smallContext[33] >> 4));
        fingerprint[4] =
            (byte)((((fingerprint[4] ^ smallContext[229]) & 0xf ^ smallContext[229]) ^ smallContext[58]) & 0xF ^
                   ((fingerprint[4] ^ smallContext[229]) & 0xf ^ smallContext[229]));
        fingerprint[5] =
            (byte)((((fingerprint[5] ^ smallContext[69]) & 0xf ^ smallContext[69]) ^ smallContext[165]) & 0xF ^
                   ((fingerprint[5] ^ smallContext[69]) & 0xf ^ smallContext[69]));
        fingerprint[6] = (byte)(((fingerprint[6] ^ smallContext[63]) & 0xf ^ smallContext[63]) & 0xF0 |
                                (smallContext[89] >> 4));
        fingerprint[7] = (byte)((((fingerprint[7] ^ smallContext[172]) & 0xf ^ smallContext[172]) ^ smallContext[247]) &
                                0xF ^
                                ((fingerprint[7] ^ smallContext[172]) & 0xf ^ smallContext[172]));
    }

    internal static void InitializeContexts(Span<byte> smallContext, Span<uint> bigContext,
        ReadOnlySpan<byte> challenge)
    {
        if (smallContext.Length < FingerprintConsts.SmallContextLength)
        {
            throw new ArgumentException(
                $"Small context buffer must be at least {FingerprintConsts.SmallContextLength} bytes long",
                nameof(smallContext));
        }

        if (bigContext.Length < FingerprintConsts.BigContextLengthDword)
        {
            throw new ArgumentException(
                $"Big context buffer must be at least {FingerprintConsts.BigContextLengthDword} dwords long",
                nameof(bigContext));
        }

        FingerprintConsts.BigContextInitialValue.CopyTo(bigContext);
        challenge.Slice(2, 16).CopyTo(smallContext);
    }

    internal static void FingerprintSubProcedure(Span<ushort> data1, uint xorMagic, Span<ushort> data2,
        Span<byte> smallContext, ReadOnlySpan<uint> bigContext)
    {
        var data2Bytes = data2.AsBytes();

        int index = 0;
        uint ctxOffset = 0;

        do
        {
            byte pwVar0 = PwVarRead(data1[index++], smallContext);
            byte pwVar1 = PwVarRead(data1[index++], smallContext);
            ushort pwVar2 = data1[index++];

            uint static3 = (uint)((pwVar1 & 0xF) | (pwVar0 << 4)) & 0xFF;

            uint t1 = (static3 >> 3) + (ctxOffset >> 2);
            int mod = (int)t1 % 0x2F;
            uint t3 = bigContext[mod];
            uint static6 = t3 ^ xorMagic;

            byte t4 = (byte)(((0x7 - (pwVar1 & 0x7)) * 0x04) & 0x1F);
            byte static5 = (byte)(static6 >> t4);

            byte bVar3 = (byte)(((byte)pwVar2 & 0x1) * -4 + 4);
            int ctxBufferIndex = pwVar2 >> 1;

            byte t5 = (byte)(bVar3 & 0x1F);
            int data2Index = (int)((static3 >> 1) + ctxOffset);

            byte fVal = (byte)((((data2Bytes[data2Index] >> (PwVarMask(pwVar1))) ^ static5) & 0xF) << t5 |
                               ((0xF0 >> t5) & smallContext[ctxBufferIndex]));

            smallContext[ctxBufferIndex] = fVal;

            ctxOffset += 0x80;
        } while (index < data1.Length);
    }

    private static byte PwVarMask(byte value) =>
        (byte)((((value & 0x1) * -4) + 4) & 0x1F);

    private static byte PwVarRead(ushort value, ReadOnlySpan<byte> smallContext) =>
        (byte)(smallContext[value >> 1] >> PwVarMask((byte)value));
}