using System.Buffers.Binary;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace HarpoS7.Utilities.Extensions;

public static class SpanExtensions
{
    private static int _staticFillIndex = 0;
    private static byte[]? _staticFillSequence;

    internal static byte[]? StaticFillSequence
    {
        get => _staticFillSequence;
        set
        {
            _staticFillSequence = value;
            _staticFillIndex = 0;
        }
    }

    static SpanExtensions()
    {
        #if DEBUG
        ResetStaticSequence();
        #endif
    }

    internal static void ResetStaticSequence()
    {
        StaticFillSequence = [0x33];
    }
    
    #region Span

    public static void FillWithCryptoRandomBytes(this Span<byte> spanOfBytes)
    {
        if (StaticFillSequence != null)
        {
            var fillByte = StaticFillSequence[_staticFillIndex++];
            if (_staticFillIndex >= StaticFillSequence.Length)
            {
                _staticFillIndex = 0;
            }
            
            spanOfBytes.Fill(fillByte);
        }
        else
        {
            RandomNumberGenerator.Fill(spanOfBytes);
        }
    }

    public static void ReverseBytes(this Span<byte> data, Span<byte> destination)
    {
        if (data.Length % sizeof(ulong) != 0)
        {
            throw new NotImplementedException();
        }
        if (destination.Length < data.Length)
        {
            throw new ArgumentException("Destination length must be larger or equal to data", nameof(destination));
        }

        var dataQword = data.AsQwords();
        var destQword = destination[..(data.Length)].AsQwords();
        dataQword.ReverseBytes(destQword);
    }

    public static void ReverseBytes(this Span<ulong> data, Span<ulong> destination)
    {
        var odd = data.Length % 2 != 0;
        if (destination.Length < data.Length)
        {
            throw new ArgumentException("Destination length must be larger or equal to data", nameof(destination));
        }

        for (int i = 0; i < data.Length / 2; ++i)
        {
            ulong a = data[i];
            ulong b = data[^(i + 1)];

            destination[i] = BinaryPrimitives.ReverseEndianness(b);
            destination[^(i + 1)] = BinaryPrimitives.ReverseEndianness(a);
        }

        if (odd)
        {
            var index = data.Length / 2 + 1;
            destination[index] = BinaryPrimitives.ReverseEndianness(data[index]);
        }
    }

    public static Span<ulong> AsQwords(this Span<byte> spanOfBytes)
    {
        if (spanOfBytes.Length <= 0)
        {
            throw new ArgumentException("Length of the span cannot be 0");
        }
        if (spanOfBytes.Length % sizeof(ulong) != 0)
        {
            throw new ArgumentException($"Length of the span must be a multiple of {sizeof(ulong)}");
        }

        return MemoryMarshal.Cast<byte, ulong>(spanOfBytes);
    }

    public static Span<uint> AsDwords(this Span<byte> spanOfBytes)
    {
        if (spanOfBytes.Length <= 0)
        {
            throw new ArgumentException("Length of the span cannot be 0");
        }
        if (spanOfBytes.Length % sizeof(uint) != 0)
        {
            throw new ArgumentException($"Length of the span must be a multiple of {sizeof(uint)}");
        }

        return MemoryMarshal.Cast<byte, uint>(spanOfBytes);
    }

    public static Span<byte> AsBytes(this Span<ulong> spanOfQwords)
    {
        if (spanOfQwords.Length <= 0)
        {
            throw new ArgumentException("Length of the span cannot be 0");
        }

        return MemoryMarshal.Cast<ulong, byte>(spanOfQwords);
    }

    public static Span<byte> AsBytes(this Span<uint> spanOfDwords)
    {
        if (spanOfDwords.Length <= 0)
        {
            throw new ArgumentException("Length of the span cannot be 0");
        }

        return MemoryMarshal.Cast<uint, byte>(spanOfDwords);
    }
    #endregion

    #region ReadOnlySpan
    public static void ReverseBytes(this ReadOnlySpan<ulong> data, Span<ulong> destination)
    {
        if (data.Length % 2 != 0)
        {
            throw new NotImplementedException();
        }
        if (destination.Length < data.Length)
        {
            throw new ArgumentException("Destination length must be larger or equal to data", nameof(destination));
        }

        for (int i = 0; i < data.Length / 2; ++i)
        {
            ulong a = data[i];
            ulong b = data[^(i + 1)];

            destination[i] = BinaryPrimitives.ReverseEndianness(b);
            destination[^(i + 1)] = BinaryPrimitives.ReverseEndianness(a);
        }
    }

    public static void ReverseBytes(this ReadOnlySpan<byte> data, Span<byte> destination)
    {
        if (data.Length % sizeof(ulong) != 0)
        {
            throw new NotImplementedException();
        }
        if (destination.Length < data.Length)
        {
            throw new ArgumentException("Destination length must be larger or equal to data", nameof(destination));
        }

        var dataQword = data.AsQwords();
        var destQword = destination[..(data.Length)].AsQwords();
        dataQword.ReverseBytes(destQword);
    }

    public static ReadOnlySpan<ulong> AsQwords(this ReadOnlySpan<byte> spanOfBytes)
    {
        if (spanOfBytes.Length <= 0)
        {
            throw new ArgumentException("Length of the span cannot be 0");
        }
        if (spanOfBytes.Length % sizeof(ulong) != 0)
        {
            throw new ArgumentException($"Length of the span must be a multiple of {sizeof(ulong)}");
        }

        return MemoryMarshal.Cast<byte, ulong>(spanOfBytes);
    }

    public static ReadOnlySpan<uint> AsDwords(this ReadOnlySpan<byte> spanOfBytes)
    {
        if (spanOfBytes.Length <= 0)
        {
            throw new ArgumentException("Length of the span cannot be 0");
        }
        if (spanOfBytes.Length % sizeof(uint) != 0)
        {
            throw new ArgumentException($"Length of the span must be a multiple of {sizeof(uint)}");
        }

        return MemoryMarshal.Cast<byte, uint>(spanOfBytes);
    }

    public static ReadOnlySpan<byte> AsBytes(this ReadOnlySpan<ulong> spanOfQwords)
    {
        if (spanOfQwords.Length <= 0)
        {
            throw new ArgumentException("Length of the span cannot be 0");
        }

        return MemoryMarshal.Cast<ulong, byte>(spanOfQwords);
    }
    #endregion
}