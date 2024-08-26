using System.Runtime.InteropServices;
using HarpoS7.Family0.Data;
using HarpoS7.Family0.Monoliths;
using HarpoS7.Family0.Utils;

namespace HarpoS7.Family0.Transforms;

/// <summary>
/// Challenge encryption key derivation
/// </summary>
public static class KeyDerivationTransform
{    
    public const int SourceSize = 0x3C;
    public const int DestinationSize = 0x30;
    
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
        
        const int buffer1Size = 0x18 * sizeof(uint);
        Span<byte> buffer1 = stackalloc byte[buffer1Size];
        Span<uint> buffer1Dwords = MemoryMarshal.Cast<byte, uint>(buffer1);
        
        buffer1Dwords[..2].Fill(uint.MaxValue);
        buffer1Dwords[2] = 0x0000FFFF;
        
        // Copy source
        source[..SourceSize].CopyTo(buffer1[(3 * sizeof(uint))..]);

        const int buffer2Size = 0xC5 * sizeof(uint);
        Span<byte> buffer2 = stackalloc byte[buffer2Size];
        Span<uint> buffer2Dwords = MemoryMarshal.Cast<byte, uint>(buffer2);
        
        Monolith10.Execute(buffer2, buffer1);

        Span<byte> monolith9Destination = stackalloc byte[MonolithBufferSizes.GetDestinationBufferSize(9)];
        Span<uint> monolith9DestinationDwords = MemoryMarshal.Cast<byte, uint>(monolith9Destination);
        
        Span<uint> dstDwords = MemoryMarshal.Cast<byte, uint>(destination);
        
        for (var i = 0; i < 6; ++i)
        {
            buffer2Dwords[0xC0] = SharedData.Data.Span[i * 2];
            buffer2Dwords[0xC1] = SharedData.Data.Span[i * 2 + 1];
            buffer2Dwords[0xC2] = SharedData.Data.Span[0x12 + i * 3];
            buffer2Dwords[0xC3] = SharedData.Data.Span[0x12 + i * 3 + 1];
            buffer2Dwords[0xC4] = SharedData.Data.Span[0x12 + i * 3 + 2];
            
            Monolith9.Execute(monolith9Destination, buffer2);

            dstDwords[i * 2] = monolith9DestinationDwords[0];
            dstDwords[i * 2 + 1] = monolith9DestinationDwords[1];

            if (i == 2)
            {
                buffer1Dwords[..3].Clear();
                Monolith10.Execute(buffer2, buffer1);
            }
        }
    }
}