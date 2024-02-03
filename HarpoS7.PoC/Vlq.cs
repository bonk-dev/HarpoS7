namespace HarpoS7.PoC;

/// <summary>
/// Class responsible for encoding/decoding VLQ numbers
/// which I stole from my own WIP S7-Comm-Plus library
/// </summary>
public static class Vlq
{
    public static uint DecodeAsVlq32(ReadOnlySpan<byte> bytes, out int length)
    {
        uint value = 0U;

        int index = 0;
        byte vlqPartValue;

        do
        {
            value <<= 7;

            vlqPartValue = bytes[index++];
            value |= (byte)(vlqPartValue & 0b0111_1111);
        } while ((vlqPartValue & 0b1000_0000) != 0 && index < 5);

        length = index;
        return value;
    }
    
    public static int EncodeAsVlq(this ulong value, Span<byte> destination)
    {
        if (value == 0x00UL)
        {
            destination[0] = 0x00;
            return 1;
        }

        const int vlqBufferLength = sizeof(ulong) + 1;

        Span<byte> vlqSpan = stackalloc byte[vlqBufferLength];

        byte vlqEncodedPart;
        int index = 0;

        ulong remainingValue = value;
        const ulong lastOctetMask = (0xFFUL << ((vlqBufferLength - 2) * 8));

        bool fullVlq = false;
        if ((value & lastOctetMask) != 0)
        {
            // this value will be encoded as a 9 byte VLQ

            fullVlq = true;

            vlqEncodedPart = (byte)remainingValue;
            vlqSpan[^++index] = vlqEncodedPart;
            remainingValue >>= 8;
        }

        while (remainingValue > 0)
        {
            vlqEncodedPart = (byte)(remainingValue & 0b0111_1111);
            vlqEncodedPart |= 0b1000_0000;

            vlqSpan[^++index] = vlqEncodedPart;
            remainingValue >>= 7;
        }

        if (!fullVlq)
        {
            // reset the VLQ bit on the least significant octet
            vlqSpan[^1] &= (0b0111_1111);
        }

        vlqSpan[(vlqBufferLength - index)..].CopyTo(destination);
        return index;
    }
}