using System.Diagnostics;
using System.Runtime.InteropServices;
using HarpoS7.Family0.Data;
using HarpoS7.Family0.Exceptions;
using HarpoS7.Family0.Monoliths;
using HarpoS7.Family0.Utils;
using HarpoS7.Utilities.Extensions;

namespace HarpoS7.Family0.Transforms;

public static class Transform6
{
    public const int DestinationSize = 0x3C;
    public const int PublicKeyLength = 0x28;
    public const int Transform1Size = Transform1.DestinationSize;
    
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> publicKey, ReadOnlySpan<byte> transform1)
    {
        if (destination.Length < DestinationSize)
        {
            throw new BufferLengthException(
                nameof(destination), false, DestinationSize, destination.Length);
        }
        if (publicKey.Length < PublicKeyLength)
        {
            throw new BufferLengthException(
                nameof(publicKey), true, PublicKeyLength, publicKey.Length);
        }
        if (transform1.Length < Transform1Size)
        {
            throw new BufferLengthException(
                nameof(transform1), true, Transform1Size, transform1.Length);
        }
        
        Span<byte> prngBuffer1 = stackalloc byte[0x14];
        prngBuffer1.FillWithCryptoRandomBytes();

        Span<byte> prngBuffer2 = stackalloc byte[0x14];
        Span<byte> transform7Destination = stackalloc byte[Transform7.DestinationSize];
        Span<byte> workBuffer = stackalloc byte[5 * sizeof(uint)];
        var t7Loop = 0U;
        
        while (t7Loop == 0)
        {
            prngBuffer2.FillWithCryptoRandomBytes();
            Transform7.Execute(
                transform7Destination, 
                prngBuffer1, 
                prngBuffer2, 
                Transform7Data.Data.Span[0xD8..]
            );
            
            Monolith1.Loop(transform7Destination, transform7Destination);
            Monolith2.Execute(workBuffer, transform7Destination);

            var workBufferDwords = MemoryMarshal.Cast<byte, uint>(workBuffer);
            t7Loop = 0U;
            
            for (var i = 0; i < 5; ++i)
            {
                t7Loop |= workBufferDwords[i];
            }
        }
        
        workBuffer[..0x14].CopyTo(destination[0x14..]);
        prngBuffer1[..0x14].CopyTo(destination[0x28..]);
        
        Transform7.Execute(transform7Destination, prngBuffer1, prngBuffer2, publicKey);
        Monolith1.Loop(transform7Destination, transform7Destination);

        Span<byte> monolith8Buffer = stackalloc byte[20 + MonolithBufferSizes.GetSourceBufferSize(8)];
        Monolith8.Execute(monolith8Buffer[20..], transform7Destination);
        
        Span<byte> monolith11Buffer = stackalloc byte[MonolithBufferSizes.GetSourceBufferSize(11)];
        Transform13.Execute(monolith11Buffer[0x3C..], monolith8Buffer[20..]);
        
        transform1[..(0xF * sizeof(uint))].CopyTo(monolith11Buffer);
        Debugger.Break();
        Monolith11.Execute(monolith8Buffer, monolith11Buffer);
        
        monolith8Buffer[..(5 * sizeof(uint))].CopyTo(destination);
    }
}