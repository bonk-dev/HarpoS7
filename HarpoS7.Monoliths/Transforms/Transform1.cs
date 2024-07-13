using System.Runtime.InteropServices;
using HarpoS7.Monoliths.Data;
using HarpoS7.Monoliths.Exceptions;
using HarpoS7.Monoliths.Impl;
using HarpoS7.Monoliths.Utils;

namespace HarpoS7.Monoliths.Transforms;

/// <summary>
/// Used in encrypted seed creation
/// <para>Uses <see cref="Impl.Monolith9"/></para>
/// </summary>
public static class Transform1
{
    private static readonly Memory<uint> MagicPostfix = new uint[3]
    {
        0x4F5BB379,
        0x90BA725F,
        0x36A4D7BB
    };
    
    public const int SourceSize = 0x18;
    public const int DestinationSize = 0x3C;

    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        if (destination.Length < DestinationSize)
        {
            throw new ArgumentException(
                $"The destination buffer is too small ({destination.Length} bytes, should be at least {DestinationSize})",
                nameof(destination));
        }
        if (source.Length < SourceSize)
        {
            throw new ArgumentException(
                $"The source buffer is too small ({source.Length} bytes, should be at least {SourceSize})",
                nameof(source));
        }
        
        const int workBufferLength = 0xC5;
        Span<uint> workBuffer = stackalloc uint[workBufferLength];
        Transform1Data.Data.Span.CopyTo(workBuffer);

        const int magicOffset = 0xC2;
        MagicPostfix.Span.CopyTo(workBuffer[magicOffset..]);

        var dstDwords = MemoryMarshal.Cast<byte, uint>(destination);
        var srcDwords = MemoryMarshal.Cast<byte, uint>(source);
        var workBufferBytes = MemoryMarshal.Cast<uint, byte>(workBuffer);

        Span<byte> monolith9Destination = stackalloc byte[MonolithBufferSizes.GetDestinationBufferSize(9)];
        var monolith9DestinationDwords = MemoryMarshal.Cast<byte, uint>(monolith9Destination);
        
        for (var i = 0; i < 3; ++i)
        {
            workBuffer[0xC0] = srcDwords[i * 2];
            workBuffer[0xC1] = srcDwords[i * 2 + 1];
            
            Monolith9.Execute(monolith9Destination, workBufferBytes);

            var dstCopyLength = i < 2 
                ? 6 
                : 3;
            monolith9DestinationDwords[..dstCopyLength].CopyTo(dstDwords[(i * 6)..]);
        }
    } 
}