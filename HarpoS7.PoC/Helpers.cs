using System.Globalization;

namespace HarpoS7.PoC;

public static class Helpers
{
    public static void PrintBuffer(ReadOnlyMemory<byte> buffer)
    {
        var span = buffer.Span;
        
        Console.Write("[");
        for (var i = 0; i < span.Length; ++i)
        {
            Console.Write("0x");
            Console.Write(span[i].ToString("X2"));

            if (i < span.Length - 1)
            {
                Console.Write(", ");
            }
        }
        
        Console.WriteLine("]");
    }

    public static void ParseAndReverseBytes(string fingerprint, Span<byte> destination)
    {
        if (!fingerprint.StartsWith("03:"))
        {
            throw new Exception("Invalid fingerprint");
        }

        fingerprint = fingerprint.Replace("03:", string.Empty);

        // I didn't see this happen, but let's better be safe than sorry
        if (fingerprint.Length % 2 != 0)
        {
            fingerprint = '0' + fingerprint;
        }

        if (destination.Length < fingerprint.Length / 2)
        {
            throw new ArgumentException($"Destination too small (need at least: {fingerprint.Length / 2}, got: {destination.Length})",
                nameof(destination));
        }

        var j = 0;
        for (var i = fingerprint.Length - 1; i >= 0; i -= 2)
        {
            var b = byte.Parse($"{fingerprint[i - 1]}{fingerprint[i]}", NumberStyles.HexNumber);
            destination[j++] = b;
        } 
    }
}