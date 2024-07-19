using System.Runtime.InteropServices;

namespace HarpoS7.Utilities;

/// <summary>
/// Like <see cref="System.Numerics.BigInteger"/> but directly working on buffers  
/// </summary>
public class BigIntegerBuffer
{
    /// <summary>
    /// Reads two big integers and adds them big integers
    /// </summary>
    /// <param name="sum">Result of first big integer + second big integer</param>
    /// <param name="a">First big integer</param>
    /// <param name="b">Second big integer</param>
    /// <returns>Sum of the first a DWORD and the first b DWORD has overflown</returns>
    public static bool AddLowEndian(Span<byte> sum, ReadOnlySpan<byte> a, ReadOnlySpan<byte> b)
    {
        var aDwords = MemoryMarshal.Cast<byte, uint>(a);
        var bDwords = MemoryMarshal.Cast<byte, uint>(b);
        var sumDwords = MemoryMarshal.Cast<byte, uint>(sum);

        var firstDwordOverflow = (aDwords[0] + bDwords[0]) < aDwords[0];
        
        var carry = 0u;
        for (var i = 0; i < aDwords.Length; ++i)
        {
            var abSum = aDwords[i] + bDwords[i] + carry;
            carry = abSum < aDwords[i] ? 1U : 0U;

            sumDwords[i] = abSum;
        }

        return firstDwordOverflow;
    }
}