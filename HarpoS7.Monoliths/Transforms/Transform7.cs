using System.Diagnostics;
using System.Runtime.InteropServices;
using HarpoS7.Monoliths.BitOperations;
using HarpoS7.Monoliths.Data;
using HarpoS7.Monoliths.Impl;

namespace HarpoS7.Monoliths.Transforms;

public static class Transform7
{
    public const int DestinationSize = Monolith4.DestinationSize;
    
    // prng1 at least 5 DWORDs
    public static void Execute(Span<byte> destination, Span<byte> prng1, Span<byte> prng2, ReadOnlySpan<byte> source)
    {
        var prng1Dwords = MemoryMarshal.Cast<byte, uint>(prng1);
        var prng2Dwords = MemoryMarshal.Cast<byte, uint>(prng2);
        var sourceDwords = MemoryMarshal.Cast<byte, uint>(source);
        
        // TODO: This maybe should be on the heap as well?
        Span<byte> workBuffer = stackalloc byte[600 * sizeof(uint)];
        workBuffer.Clear();
        var workBufferDwords = MemoryMarshal.Cast<byte, uint>(workBuffer);
        
        prng1Dwords[..0x5].CopyTo(workBufferDwords[0xC..]);
        workBufferDwords[0xC] |= 4;
        
        sourceDwords[..5].CopyTo(workBufferDwords);
        sourceDwords.Slice(5, 0x5).CopyTo(workBufferDwords[0x12..]);
        workBufferDwords[0x12] |= 4;

        var data = Transform7Data.Data.Span;
        Monolith3.WithCopy(
            workBuffer[0xA8..],
            workBuffer[0x60..],
            data, 
            data[0x48..],
            workBuffer[0x30..]
        );
        Monolith3.WithCopy(
            workBuffer[0x2A0..],
            workBuffer[0x210..],
            data, 
            data[0x48..],
            workBuffer[0x48..]
        );
        Monolith3.WithCopy(
            workBuffer[0x1C8..],
            workBuffer[0xF0..],
            workBuffer[0xA8..], 
            workBuffer[0x60..],
            workBuffer
        );
        Monolith3.WithCopy(
            workBuffer[0x180..],
            workBuffer[0x138..],
            workBuffer[0x1C8..], 
            workBuffer[0xF0..],
            workBuffer[0x48..]
        );
        
        Monolith4.WithCopy(workBuffer[0x4E0..], workBuffer[0x180..], workBuffer[0x138..]);

        // TODO: Move to heap
        // as much as I love stackalloc, this is way too big
        Span<byte> ctx = stackalloc byte[894 * sizeof(uint)];
        ctx.Clear();
        
        Monolith5.WithCopy(
            ctx[0x450..],
            workBuffer[0x18..],
            workBuffer[0x4E0..],
            workBuffer[0x180..],
            workBuffer[0x138..]
        );
        
        Transform8.Execute(
            ctx[0x450..],
            ctx[0x450..],
            workBuffer[0x18..]
        );
        
        Monolith3.WithCopy(
            workBuffer[0x498..], 
            workBuffer[0x768..],
            workBuffer[0x180..], 
            workBuffer[0x138..],
            workBuffer[0x30..]
        );
        
        Monolith4.WithCopy(workBuffer[0x648..], data, data[0x48..]);
        Monolith6.WithCopy(
            workBuffer[0x8D0..],
            workBuffer[0x888..],
            workBuffer[0x648..],
            workBuffer[0xA8..],
            workBuffer[0x60..]
        );
        
        Monolith4.WithCopy(workBuffer[0x570..], workBuffer[0x498..], workBuffer[0x768..]);
        Monolith6.WithCopy(
            workBuffer[0x330..],
            workBuffer[0x690..],
            workBuffer[0x570..],
            workBuffer[0x2A0..],
            workBuffer[0x210..]
        );
        
        // OFFSETS NOT CHECKED PAST THIS LINE
        
        Monolith4.WithCopy(workBuffer[0x840..], workBuffer[0xA8..], workBuffer[0x60..]);
        Monolith6.WithCopy(
            workBuffer[0x7F8..],
            workBuffer[0x6D8..],
            workBuffer[0x840..],
            workBuffer[0x1C8..],
            workBuffer[0xF0..]
        );
        
        Monolith4.WithCopy(workBuffer[0x5B8..], workBuffer[0x7F8..], workBuffer[0x6D8..]);
        Monolith6.WithCopy(
            workBuffer[0x3C0..],
            workBuffer[0x450..],
            workBuffer[0x5B8..],
            workBuffer[0x2A0..],
            workBuffer[0x210..]
        );
        
        Monolith4.WithCopy(workBuffer[0x600..], workBuffer[0x3C0..], workBuffer[0x450..]);
        Monolith5.WithCopy(
            ctx[0x690..],
            workBuffer[0x18..],
            workBuffer[0x600..],
            workBuffer[0x3C0..],
            workBuffer[0x450..]
        );
        
        Transform8.Execute(
            ctx[0x690..],
            ctx[0x690..],
            workBuffer[0x18..]
        );
        
        Monolith4.WithCopy(workBuffer[0x378..], workBuffer[0x330..], workBuffer[0x690..]);
        Monolith6.WithCopy(
            workBuffer[0x2E8..],
            workBuffer[0x258..],
            workBuffer[0x378..],
            workBuffer[0x3C0..],
            workBuffer[0x450..]
        );
        
        Monolith4.WithCopy(workBuffer[0x408..], workBuffer[0x2E8..], workBuffer[0x258..]);
        Monolith5.WithCopy(
            ctx[0x480..],
            workBuffer[0x18..],
            workBuffer[0x408..],
            workBuffer[0x2E8..],
            workBuffer[0x258..]
        );
        
        Transform8.Execute(
            ctx[0x480..],
            ctx[0x480..],
            workBuffer[0x18..]
        );
        
        // ..(6 uints) is for verbosity
        BigIntOperations.RotateRight30(workBuffer[..(6 * sizeof(uint))]);
        
        Monolith3.WithCopy(
            workBuffer[0xA8..],
            workBuffer[0x60..],
            data, 
            data, 
            workBuffer
        );
        Monolith5.WithCopy(
            ctx[0x8D0..],
            workBuffer[0x18..],
            data, 
            workBuffer[0xA8..], 
            workBuffer[0x60..]
        );
        
        Transform8.Execute(
            ctx[0x8D0..],
            ctx[0x8D0..],
            workBuffer[0x18..]
        );

        for (uint i = 0; i < 0xA0; ++i)
        {
            var prng2Index = (int)((0x9F - i) >> 0x5);
            var transform12DataIndex = (prng2Dwords[prng2Index] >> (byte)((0xFFFFFFFFU - i) & 0x1F)) & 1;
            transform12DataIndex += i * 2;
            
            Transform12.Execute(
                ctx, 
                Transform7Data.Indexes.Span[(int)transform12DataIndex], 
                Transform7Data.Counts.Span[(int)transform12DataIndex]
            );
        }

        for (uint i = 0xA0; i < 0xF9; ++i)
        {
            // Reads PRNG bytes
            var transform12DataIndex = workBufferDwords[(int)((i - 0xA0 >> 5) + 0xC)];
            transform12DataIndex >>= (byte)i & 0x1F;
            transform12DataIndex &= 1;
            transform12DataIndex += i * 2;
            
            Transform12.Execute(
                ctx,
                Transform7Data.Indexes.Span[(int)transform12DataIndex], 
                Transform7Data.Counts.Span[(int)transform12DataIndex]
            );
        }
        
        BigIntOperations.PrepareFinalize(ctx[0x918..]);
        BigIntOperations.PrepareFinalize(ctx[0x6A8..]);
        BigIntOperations.PrepareFinalize(ctx[0x5B8..]);
        BigIntOperations.PrepareFinalize(ctx[0x288..]);
        
        Monolith7.WithCopy(
            workBuffer[0x7B0..],
            workBuffer[0x720..], 
            ctx[0x288..], 
            data[0x90..]
        );
        Monolith4.WithCopy(workBuffer[0x528..], workBuffer[0x7B0..], workBuffer[0x720..]);
        
        Monolith7.WithCopy(
            workBuffer[0xA8..],
            workBuffer[0x60..], 
            ctx[0x288..], 
            workBuffer[0x528..]
        );
        Monolith4.WithCopy(workBuffer[0x2A0..], workBuffer[0xA8..], workBuffer[0x60..]);
        
        Monolith7.WithCopy(
            workBuffer[0x210..],
            workBuffer[0x1C8..], 
            ctx[0x5B8..], 
            workBuffer[0x2A0..]
        );
        Monolith4.WithCopy(workBuffer[0xF0..], workBuffer[0x210..], workBuffer[0x1C8..]);
        
        Monolith7.WithCopy(
            workBuffer[0x180..],
            workBuffer[0x138..], 
            ctx[0x918..], 
            workBuffer[0xF0..]
        );
        Monolith7.WithCopy(
            workBuffer[0x4E0..],
            workBuffer[0x498..], 
            ctx[0x6A8..], 
            workBuffer[0xF0..]
        );
        
        Monolith4.WithCopy(workBuffer[0x330..], workBuffer[0x180..], workBuffer[0x138..]);
        
        Monolith6.WithCopy(
            workBuffer[0x2E8..],
            workBuffer[0x258..], 
            workBuffer[0x330..], 
            workBuffer[0xA8..],
            workBuffer[0x60..]
        );
        Monolith6.WithCopy(
            workBuffer[0x378..],
            workBuffer[0x408..], 
            workBuffer[0x528..], 
            workBuffer[0x2E8..],
            workBuffer[0x258..]
        );
        
        Monolith4.WithCopy(destination, workBuffer[0x378..], workBuffer[0x408..]);
    }
}
