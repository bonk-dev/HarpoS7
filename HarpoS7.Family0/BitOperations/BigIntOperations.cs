using System.Buffers.Binary;
using System.Runtime.InteropServices;
using HarpoS7.Family0.Exceptions;

namespace HarpoS7.Family0.BitOperations;

public static class BigIntOperations
{
    public const int PrepareDestinationSize = 0x05 * sizeof(uint);
    public const int PrepareSourceSize = 0x06 * sizeof(uint);
    
    public const int FinalizeDestinationSize = 0x06 * sizeof(uint);
    public const int FinalizeSourceSize = 0x05 * sizeof(uint);
    
    public static void Prepare(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        if (destination.Length < PrepareDestinationSize)
        {
            throw new BufferLengthException(
                nameof(destination), false, PrepareDestinationSize, destination.Length);
        }
        if (source.Length < PrepareSourceSize)
        {
            throw new BufferLengthException(
                nameof(source), true, PrepareSourceSize, source.Length);
        }

        var dstDwords = MemoryMarshal.Cast<byte, uint>(destination);
        var srcDwords = MemoryMarshal.Cast<byte, uint>(source);

        var temp0 = srcDwords[0];
        var temp1 = (srcDwords[1] << 0x1A) + (temp0 >> 2);
        dstDwords[0] = temp1;
        
        temp1 = (CarryHelper(temp1, temp0) >> 2) + (srcDwords[1] >> 6);
        temp0 = srcDwords[2] * 0x400000 + temp1;
        dstDwords[1] = temp0;
        
        temp1 = CarryHelper(temp0, temp1) + (srcDwords[2] >> 10);
        temp0 = srcDwords[3] * 0x40000 + temp1;
        dstDwords[2] = temp0;
        
        temp1 = CarryHelper(temp0, temp1) + (srcDwords[3] >> 0xe);
        temp0 = srcDwords[4] * 0x4000 + temp1;
        dstDwords[3] = temp0;
        
        temp1 = CarryHelper(temp0, temp1) + (srcDwords[4] >> 0x12);
        temp0 = srcDwords[5] * 0x400 + temp1;
        dstDwords[4] = temp0;
        
        temp0 = (CarryHelper(temp0, temp1) + (srcDwords[5] >> 0x16)) * 0x2f;
        
        if (temp0 != 0) {
            dstDwords[0] += temp0;
            dstDwords[1] += CarryHelper(dstDwords[0], temp0);
            
            temp0 = CarryHelper(dstDwords[1], CarryHelper(dstDwords[0], temp0));
            dstDwords[2] += temp0;
            
            temp0 = CarryHelper(dstDwords[2], temp0);
            dstDwords[3] += temp0;
            
            temp0 = CarryHelper(dstDwords[3], temp0);
            dstDwords[4] += temp0;
            
            dstDwords[0] += CarryHelper(dstDwords[4], temp0) * 0x2f;
        }
    }
    
    public static void Finalize(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        if (destination.Length < FinalizeDestinationSize)
        {
            throw new BufferLengthException(
                nameof(destination), false, FinalizeDestinationSize, destination.Length);
        }
        if (source.IsEmpty)
        {
            throw new ArgumentException("Source span cannot be empty", nameof(source));
        }

        Span<byte> realSource = stackalloc byte[FinalizeSourceSize];
        source[..Math.Min(source.Length, FinalizeSourceSize)].CopyTo(realSource);
        
        // Pad source with zeros
        if (realSource.Length < FinalizeSourceSize)
        {
            source
                .Slice(source.Length, FinalizeSourceSize - source.Length)
                .CopyTo(realSource);
        }

        var dstDwords = MemoryMarshal.Cast<byte, uint>(destination);
        var srcDwords = MemoryMarshal.Cast<byte, uint>(realSource);
        
        dstDwords[0] = (srcDwords[0] & 0x0FFFFFFF) << 2;
        dstDwords[1] = (srcDwords[1] << 0x06 | srcDwords[0] >> 0x1A) & 0x3FFFFFFC;
        dstDwords[2] = (srcDwords[2] << 0x0A | srcDwords[1] >> 0x16) & 0x3FFFFFFC;
        dstDwords[3] = (srcDwords[2] >> 0x12 | srcDwords[3] << 0x0E) & 0x3FFFFFFC;
        dstDwords[4] = (srcDwords[4] << 0x12 | srcDwords[3] >> 0x0E) & 0x3FFFFFFC;
        dstDwords[5] = srcDwords[4] >> 0x0A & 0x3FFFFC;
    }

    /// <summary>
    /// <see cref="Prepare"/> and <see cref="Finalize"/> joined together
    /// </summary>
    /// <param name="destinationSource"></param>
    public static void PrepareFinalize(Span<byte> destinationSource)
    {
        if (destinationSource.Length < FinalizeDestinationSize)
        {
            throw new BufferLengthException(
                nameof(destinationSource), false, FinalizeDestinationSize, destinationSource.Length);
        }

        var destinationSourceDwords = MemoryMarshal.Cast<byte, uint>(destinationSource);
        
        var temp0 = destinationSourceDwords[1] * 0x4000000 + (destinationSourceDwords[0] >> 2);
        var temp1 = CarryHelper(temp0, destinationSourceDwords[0] >> 2) + (destinationSourceDwords[1] >> 6);
        
        var temp2 = destinationSourceDwords[2] * 0x400000 + temp1;
        temp1 = CarryHelper(temp2, temp1) + (destinationSourceDwords[2] >> 10);
        
        var temp3 = destinationSourceDwords[3] * 0x40000 + temp1;
        temp1 = CarryHelper(temp3, temp1) + (destinationSourceDwords[3] >> 0xe);
        
        var temp4 = destinationSourceDwords[4] * 0x4000 + temp1;
        temp1 = CarryHelper(temp4, temp1) + (destinationSourceDwords[4] >> 0x12);
        
        var temp5 = destinationSourceDwords[5] * 0x400 + temp1;
        temp1 = (CarryHelper(temp5, temp1) + (destinationSourceDwords[5] >> 0x16)) * 0x2f;
        
        if (temp1 != 0) {
            var temp6 = CarryHelper(temp0 + temp1, temp1);
            
            temp2 += temp6;
            temp6 = CarryHelper(temp2, temp6);
            
            temp3 += temp6;
            temp6 = CarryHelper(temp3, temp6);
            
            temp4 += temp6;
            temp6 = CarryHelper(temp4, temp6);
            
            temp5 += temp6;
            temp0 = temp0 + temp1 + CarryHelper(temp5, temp6) * 0x2f;
        }
        
        destinationSourceDwords[0] = (temp0 & 0xfffffff) << 2;
        destinationSourceDwords[1] = (temp2 << 6 | temp0 >> 0x1a) & 0x3ffffffc;
        destinationSourceDwords[2] = (temp3 << 10 | temp2 >> 0x16) & 0x3ffffffc;
        destinationSourceDwords[3] = (temp4 << 0xe | temp3 >> 0x12) & 0x3ffffffc;
        destinationSourceDwords[4] = (temp5 << 0x12 | temp4 >> 0xe) & 0x3ffffffc;
        destinationSourceDwords[5] = temp5 >> 10 & 0x3ffffc;
    }

    public static void RotateRight30(Span<byte> destination)
    {
        var dstD = MemoryMarshal.Cast<byte, uint>(destination);

        dstD[5] = dstD[4] >> 0x1E;
        for (var i = 4; i > 0; --i)
        {
            dstD[i] = dstD[i - 1] >> 0x1E | dstD[i] << 2;
        }
        dstD[0] <<= 0x2;
    }

    public static void RotateLeft31(Span<byte> destination)
    {
        var dstD = MemoryMarshal.Cast<byte, uint>(destination);
        var firstDword = dstD[0];
        var lastDword = dstD[3];
        
        var uInt128 = BinaryPrimitives.ReadUInt128LittleEndian(destination);
        uInt128 = UInt128.RotateLeft(uInt128, 31);
        BinaryPrimitives.WriteUInt128LittleEndian(destination, uInt128);
        
        dstD[3] = (uint)(lastDword >> 1 ^ -((firstDword & 1) != 0 ? 1U : 0U) & 0xE1000000);
    }

    private static uint CarryHelper(uint a, uint b) => 
        a < b ? 1U : 0U;
}