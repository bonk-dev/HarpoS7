using HarpoS7.Family0.Exceptions;

namespace HarpoS7.Family0.Monoliths;

/// <summary>
/// Performs a cryptographic transformation on a source buffer into a destination buffer.
/// This is a linear+quadratic mixing function that uses symmetric boolean operations on triplets of bytes.
/// The transformation combines linear XOR operations with quadratic (two-variable) boolean terms.
/// </summary>
public static class Monolith11
{
    public static void Execute(Span<byte> destination, ReadOnlySpan<byte> source)
    {
        BufferLengthException.ThrowIfBufferTooSmall(
            nameof(destination), destination, monolithIndex: 11);
        BufferLengthException.ThrowIfBufferTooSmall(
            nameof(source), source, monolithIndex: 11);

        // Process each destination byte with corresponding source triplets
        ProcessByte0(destination, source);
        ProcessByte1(destination, source);
        ProcessByte2(destination, source);
        ProcessByte3(destination, source);
        ProcessByte4(destination, source);
        ProcessByte5(destination, source);
        ProcessByte6(destination, source);
        ProcessByte7(destination, source);
        ProcessByte8(destination, source);
        ProcessByte9(destination, source);
        ProcessByte10(destination, source);
        ProcessByte11(destination, source);
        ProcessByte12(destination, source);
        ProcessByte13(destination, source);
        ProcessByte14(destination, source);
        ProcessByte15(destination, source);
        ProcessByte16(destination, source);
        ProcessByte17(destination, source);
        ProcessByte18(destination, source);
        ProcessByte19(destination, source);
    }

    #region Symmetric Operation Functions
    
    /// <summary>Symmetric operation for bytes 0, 8, 16</summary>
    private static byte SymmetricOpType0(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(x & y & 0xD4);
        r ^= (byte)(y & z & 0xAE);
        r ^= (byte)((x | z) & 0x98);
        r ^= (byte)(x & z & 0x47);
        r ^= (byte)(y & 0x40);
        r ^= (byte)((x | y) & 0x22);
        r ^= (byte)((y | z) & 0x01);
        return r;
    }

    /// <summary>Symmetric operation for bytes 1, 9, 17</summary>
    private static byte SymmetricOpType1(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(x & y & 0xDC);
        r ^= (byte)((y | z) & 0x80);
        r ^= (byte)(y & z & 0x7B);
        r ^= (byte)(x & z & 0x4B);
        r ^= (byte)((x | y) & 0x20);
        r ^= (byte)(z & 0x10);
        r ^= (byte)((x | z) & 0x04);
        r ^= (byte)(y & 0x03);
        return r;
    }

    /// <summary>Symmetric operation for byte 2</summary>
    private static byte SymmetricOpType2(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(x & y & 0x9D);
        r ^= (byte)(y & z & 0x8B);
        r ^= (byte)((x | z) & 0x87);
        r ^= (byte)(x & z & 0x78);
        r ^= (byte)(z & 0x40);
        r ^= (byte)((y | z) & 0x10);
        return r;
    }

    /// <summary>Symmetric operation for bytes 3, 11, 19</summary>
    private static byte SymmetricOpType3(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(x & y & 0xB6);
        r ^= (byte)(x & z & 0xAB);
        r ^= (byte)(z & 0x80);
        r ^= (byte)(y & z & 0x5D);
        r ^= (byte)((x | y) & 0x40);
        r ^= (byte)(y & 0x20);
        r ^= (byte)(x & 0x19);
        r ^= (byte)((x | z) & 0x04);
        r ^= (byte)((y | z) & 0x02);
        return r;
    }

    /// <summary>Symmetric operation for byte 4</summary>
    private static byte SymmetricOpType4(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(y & z & 0x96);
        r ^= (byte)((x | z) & 0x82);
        r ^= (byte)(x & z & 0x71);
        r ^= (byte)(x & y & 0x63);
        r ^= (byte)(y & 0x48);
        r ^= (byte)(z & 0x28);
        r ^= (byte)((x | y) & 0x14);
        r ^= (byte)(x & 0x08);
        r ^= (byte)((y | z) & 0x01);
        return r;
    }

    /// <summary>Symmetric operation for bytes 5, 13</summary>
    private static byte SymmetricOpType5(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(y & z & 0xDE);
        r ^= (byte)(x & y & 0x8B);
        r ^= (byte)(x & 0x82);
        r ^= (byte)((x | y) & 0x54);
        r ^= (byte)(x & z & 0x3D);
        r ^= (byte)((y | z) & 0x20);
        r ^= (byte)(z & 0x01);
        return r;
    }

    /// <summary>Symmetric operation for bytes 6, 14</summary>
    private static byte SymmetricOpType6(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(y & z & 0xA7);
        r ^= (byte)((x | y) & 0x90);
        r ^= (byte)(x & z & 0x75);
        r ^= (byte)(x & y & 0x4F);
        r ^= (byte)((y | z) & 0x48);
        r ^= (byte)(x & 0x20);
        r ^= (byte)((x | z) & 0x02);
        return r;
    }

    /// <summary>Symmetric operation for bytes 7, 15</summary>
    private static byte SymmetricOpType7(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)((x | y) & 0xC4);
        r ^= (byte)(x & z & 0xA7);
        r ^= (byte)(y & z & 0x7D);
        r ^= (byte)(x & 0x28);
        r ^= (byte)(x & y & 0x1B);
        r ^= (byte)(z & 0x10);
        r ^= (byte)(y & 0x02);
        return r;
    }

    /// <summary>Symmetric operation for bytes 10, 18</summary>
    private static byte SymmetricOpType10(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(x & y & 0xBD);
        r ^= (byte)(y & z & 0xAB);
        r ^= (byte)((x | z) & 0xA7);
        r ^= (byte)(x & z & 0x58);
        r ^= (byte)((y | z) & 0x50);
        return r;
    }

    /// <summary>Symmetric operation for byte 12</summary>
    private static byte SymmetricOpType12(byte x, byte y, byte z)
    {
        byte r = 0;
        r ^= (byte)(y & z & 0x9E);
        r ^= (byte)((x | z) & 0x8A);
        r ^= (byte)(x & z & 0x71);
        r ^= (byte)(x & y & 0x63);
        r ^= (byte)(y & 0x40);
        r ^= (byte)(z & 0x20);
        r ^= (byte)((x | y) & 0x14);
        r ^= (byte)((y | z) & 0x01);
        return r;
    }

    #endregion

    #region Byte Processing Methods

    private static void ProcessByte0(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x00] ^= SymmetricOpType0(src[0x00], src[0x04], src[0x08]);
        dst[0x00] ^= SymmetricOpType0(src[0x3C], src[0x40], src[0x44]);
    }

    private static void ProcessByte1(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x01] ^= SymmetricOpType1(src[0x01], src[0x05], src[0x09]);
        dst[0x01] ^= SymmetricOpType1(src[0x3D], src[0x41], src[0x45]);
    }

    private static void ProcessByte2(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x02] ^= SymmetricOpType2(src[0x02], src[0x06], src[0x0A]);
        dst[0x02] ^= SymmetricOpType2(src[0x3E], src[0x42], src[0x46]);

        // Additional non-symmetric operations for byte 2
        dst[0x02] ^= (byte)(src[0x3E] & src[0x42] & 0x60);
        dst[0x02] ^= (byte)((src[0x06] ^ (src[0x06] & src[0x0A]) ^ (src[0x06] & src[0x3E]) ^
                             (src[0x06] & src[0x42]) ^ (src[0x06] & src[0x46])) & 0x40);
        dst[0x02] ^= (byte)((src[0x3E] ^ src[0x46] ^ (src[0x02] & src[0x3E]) ^
                             (src[0x02] & src[0x42]) ^ (src[0x02] & src[0x46]) ^
                             (src[0x0A] & src[0x3E]) ^ (src[0x0A] & src[0x42]) ^
                             (src[0x0A] & src[0x46]) ^ (src[0x42] & src[0x46])) & 0x20);
    }

    private static void ProcessByte3(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x03] ^= SymmetricOpType3(src[0x03], src[0x07], src[0x0B]);
        dst[0x03] ^= SymmetricOpType3(src[0x3F], src[0x43], src[0x47]);
    }

    private static void ProcessByte4(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x04] ^= SymmetricOpType4(src[0x0C], src[0x10], src[0x14]);
        dst[0x04] ^= SymmetricOpType4(src[0x48], src[0x4C], src[0x50]);

        // Additional non-symmetric operation for byte 4
        dst[0x04] ^= (byte)(((src[0x0C] & src[0x10]) ^ (src[0x0C] & src[0x4C]) ^
                             (src[0x10] & src[0x14]) ^ (src[0x10] & src[0x50]) ^
                             (src[0x14] & src[0x48]) ^ (src[0x14] & src[0x4C]) ^
                             (src[0x14] & src[0x50]) ^ (src[0x48] & src[0x50])) & 0x08);
    }

    private static void ProcessByte5(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x05] ^= SymmetricOpType5(src[0x0D], src[0x11], src[0x15]);
        dst[0x05] ^= SymmetricOpType5(src[0x49], src[0x4D], src[0x51]);
    }

    private static void ProcessByte6(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x06] ^= SymmetricOpType6(src[0x0E], src[0x12], src[0x16]);
        dst[0x06] ^= SymmetricOpType6(src[0x4A], src[0x4E], src[0x52]);
    }

    private static void ProcessByte7(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x07] ^= SymmetricOpType7(src[0x0F], src[0x13], src[0x17]);
        dst[0x07] ^= SymmetricOpType7(src[0x4B], src[0x4F], src[0x53]);
    }

    private static void ProcessByte8(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x08] ^= SymmetricOpType0(src[0x18], src[0x1C], src[0x20]);
        dst[0x08] ^= SymmetricOpType0(src[0x54], src[0x58], src[0x5C]);
    }

    private static void ProcessByte9(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x09] ^= SymmetricOpType1(src[0x19], src[0x1D], src[0x21]);
        dst[0x09] ^= SymmetricOpType1(src[0x55], src[0x59], src[0x5D]);
    }

    private static void ProcessByte10(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x0A] ^= SymmetricOpType10(src[0x1A], src[0x1E], src[0x22]);
        dst[0x0A] ^= SymmetricOpType10(src[0x56], src[0x5A], src[0x5E]);
    }

    private static void ProcessByte11(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x0B] ^= SymmetricOpType3(src[0x1B], src[0x1F], src[0x23]);
        dst[0x0B] ^= SymmetricOpType3(src[0x57], src[0x5B], src[0x5F]);
    }

    private static void ProcessByte12(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x0C] ^= SymmetricOpType12(src[0x24], src[0x28], src[0x2C]);
        dst[0x0C] ^= SymmetricOpType12(src[0x60], src[0x64], src[0x68]);
    }

    private static void ProcessByte13(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x0D] ^= SymmetricOpType5(src[0x25], src[0x29], src[0x2D]);
        dst[0x0D] ^= SymmetricOpType5(src[0x61], src[0x65], src[0x69]);
    }

    private static void ProcessByte14(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x0E] ^= SymmetricOpType6(src[0x26], src[0x2A], src[0x2E]);
        dst[0x0E] ^= SymmetricOpType6(src[0x62], src[0x66], src[0x6A]);
    }

    private static void ProcessByte15(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x0F] ^= SymmetricOpType7(src[0x27], src[0x2B], src[0x2F]);
        dst[0x0F] ^= SymmetricOpType7(src[0x63], src[0x67], src[0x6B]);
    }

    private static void ProcessByte16(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x10] ^= SymmetricOpType0(src[0x30], src[0x34], src[0x38]);
        dst[0x10] ^= SymmetricOpType0(src[0x6C], src[0x70], src[0x74]);
    }

    private static void ProcessByte17(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x11] ^= SymmetricOpType1(src[0x31], src[0x35], src[0x39]);
        dst[0x11] ^= SymmetricOpType1(src[0x6D], src[0x71], src[0x75]);
    }

    private static void ProcessByte18(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x12] ^= SymmetricOpType10(src[0x32], src[0x36], src[0x3A]);
        dst[0x12] ^= SymmetricOpType10(src[0x6E], src[0x72], src[0x76]);
    }

    private static void ProcessByte19(Span<byte> dst, ReadOnlySpan<byte> src)
    {
        dst[0x13] ^= SymmetricOpType3(src[0x33], src[0x37], src[0x3B]);
        dst[0x13] ^= SymmetricOpType3(src[0x6F], src[0x73], src[0x77]);
    }

    #endregion
}