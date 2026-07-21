using System.Numerics;

namespace HarpoS7.Family0.Compatibility;

internal static class BigIntegerCompatibility
{
    public static BigInteger FromUnsignedLittleEndian(ReadOnlySpan<byte> source)
    {
#if NETSTANDARD2_0
        var bytes = new byte[source.Length + 1];
        source.CopyTo(bytes);
        return new BigInteger(bytes);
#else
        return new BigInteger(source, isUnsigned: true, isBigEndian: false);
#endif
    }

    public static int GetSignedByteCount(BigInteger value)
    {
#if NETSTANDARD2_0
        return value.ToByteArray().Length;
#else
        return value.GetByteCount();
#endif
    }

    public static int WriteLittleEndian(BigInteger value, Span<byte> destination, bool isUnsigned)
    {
#if NETSTANDARD2_0
        var bytes = value.ToByteArray();
        var length = bytes.Length;
        if (isUnsigned && value.Sign >= 0 && length > 1 && bytes[length - 1] == 0)
        {
            --length;
        }

        if (destination.Length < length)
        {
            throw new ArgumentException($"Destination must be at least {length} bytes long", nameof(destination));
        }

        bytes.AsSpan(0, length).CopyTo(destination);
        return length;
#else
        if (!value.TryWriteBytes(destination, out var length, isUnsigned, isBigEndian: false))
        {
            throw new ArgumentException("Destination is too short", nameof(destination));
        }

        return length;
#endif
    }
}
