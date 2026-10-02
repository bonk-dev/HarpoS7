using System.Numerics;
using System.Globalization;

namespace HarpoS7.Family0.Cryptography;

/// <summary>X-only ECDH on y² = x³ - x + B over GF(2^160 - 47).</summary>
internal static class LegacyCurve
{
    internal static readonly BigInteger Prime = (BigInteger.One << 160) - 47;
    internal static readonly BigInteger GeneratorX = Hex("7D2ED8E2846E58D74A7A613285471707A39D0C8E");
    internal static readonly BigInteger ScalarMask = Hex("F8E62E8673B79CA477A1D36333B1C0DE6C706448");
    private static readonly BigInteger B = Hex("FDEC56A0F1A148A7CA6F04463A24F5F56C3F3A4F");
    private static BigInteger Hex(string value) => BigInteger.Parse("0" + value, NumberStyles.HexNumber);
    private static BigInteger Mod(BigInteger value) => (value % Prime + Prime) % Prime;

    private static (BigInteger X, BigInteger Z) Double(BigInteger x, BigInteger z)
    {
        var xx = x * x % Prime;
        var zz = z * z % Prime;
        return (Mod((xx + zz) * (xx + zz) - 8 * B * x * z * zz),
            Mod(4 * z * (x * xx - x * zz + B * z * zz)));
    }

    private static (BigInteger X, BigInteger Z) Add(
        (BigInteger X, BigInteger Z) low, (BigInteger X, BigInteger Z) high, BigInteger difference)
    {
        var cross = low.X * high.Z - high.X * low.Z;
        return (Mod(2 * (low.X * high.Z + high.X * low.Z) * (low.X * high.X - low.Z * high.Z)
            + 4 * B * low.Z * low.Z * high.Z * high.Z - difference * cross * cross), Mod(cross * cross));
    }

    internal static BigInteger Multiply(BigInteger scalar, BigInteger x)
    {
        if (scalar.Sign < 0 || scalar >= (BigInteger.One << 160)) throw new ArgumentOutOfRangeException(nameof(scalar));
        x = Mod(x);
        (BigInteger X, BigInteger Z) low = (1, 0), high = (x, 1);
        // Always walk the 160-bit protocol scalar, including leading zero bits.
        for (var bit = 159; bit >= 0; bit--)
        {
            var sum = Add(low, high, x);
            if (((scalar >> bit) & 1) != 0) (low, high) = (sum, Double(high.X, high.Z));
            else (low, high) = (Double(low.X, low.Z), sum);
        }
        return low.Z.IsZero ? BigInteger.Zero : low.X * BigInteger.ModPow(low.Z, Prime - 2, Prime) % Prime;
    }
}
