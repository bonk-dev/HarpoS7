using System.Runtime.InteropServices;
using CommunityToolkit.HighPerformance.Buffers;

namespace HarpoS7.Aes;

public class HarpoAesCtr : HarpoAes
{
    private readonly MemoryOwner<byte> _lutOwner;
    private readonly MemoryOwner<byte> _encryptionBufferOwner;
    private readonly Memory<byte> _counter;
    private readonly Memory<byte> _aes2;
    private readonly Memory<byte> _aes3;
    private readonly Memory<byte> _aes4;
    // private readonly Memory<byte> _aes5; // I don't remember what this field was used for :(
    private readonly Memory<byte> _ivExtension;

    private uint _var1;
    private uint _var2;

    public HarpoAesCtr(ReadOnlySpan<byte> key) : base(key)
    {
        _lutOwner = MemoryOwner<byte>.Allocate(0x1000);
        _encryptionBufferOwner = MemoryOwner<byte>.Allocate(0x10 * 6);

        _counter = _encryptionBufferOwner.Memory.Slice(0, 0x10);
        _aes2 = _encryptionBufferOwner.Memory.Slice(0x10, 0x10);
        _aes3 = _encryptionBufferOwner.Memory.Slice(0x10 * 2, 0x10);
        _aes4 = _encryptionBufferOwner.Memory.Slice(0x10 * 3, 0x10);
        // _aes5 = _encryptionBufferOwner.Memory.Slice(0x10 * 4, 0x10);
        _ivExtension = _encryptionBufferOwner.Memory.Slice(0x10 * 5, 0x10);
    }

    public void Init(ReadOnlySpan<byte> iv)
    {
        _ivExtension.Span.Clear();
        _aes4.Span.Clear();

        // 1. encrypt zeros with AES-ECB (resulting in "seed")
        EncryptEcb(_aes4.Span, _aes4.Span);

        // 2. generate LUT with the "seed"
        Aes.HarpoHash.GenerateLookupTable(_aes4.Span, MemoryMarshal.Cast<byte, uint>(_lutOwner.Memory.Span));

        if (iv.Length == 0xC)
        {
            throw new NotImplementedException();
        }

        uint ivLength = (uint)iv.Length;

        // 3. do IV XOR and Hash
        // if the iv length is bigger than 16 bytes, xor and hash multiple times
        if (iv.Length > 0xF)
        {
            for (int i = 0; i < iv.Length / 16; ++i)
            {
                Xor(output: MemoryMarshal.Cast<byte, uint>(_ivExtension.Span),
                    a: MemoryMarshal.Cast<byte, uint>(_ivExtension.Span),
                    b: MemoryMarshal.Cast<byte, uint>(iv)[i..]);

                ivLength -= 0x10;
                Aes.HarpoHash.Hash(_ivExtension.Span, _lutOwner.Memory.Span);
            }
        }

        // 3.2. IV XOR and TbHash the rest of the IV that's left (happens when IV length is not a multiple of 16)
        if (ivLength != 0)
        {
            throw new NotImplementedException();
        }

        // 4. derive the IV extension
        uint ivLen = (uint)iv.Length << 3;
        _ivExtension.Span[0xF] ^= (byte)ivLen;
        _ivExtension.Span[0xE] ^= (byte)(ivLen >> 8);
        _ivExtension.Span[0xD] ^= (byte)(ivLen >> 16);
        _ivExtension.Span[0xC] ^= (byte)(ivLen >> 24);
        _ivExtension.Span[0xB] ^= (byte)(((uint)iv.Length) >> 29);

        // 5. Hash after XORing
        Aes.HarpoHash.Hash(_ivExtension.Span, _lutOwner.Memory.Span);

        // 6. Copy IV ext to counter field
        _ivExtension.CopyTo(_counter);

        // 7. Zero
        _aes3.Span.Fill(0x00);
        _var1 = 0;
        _var2 = 0;
    }

    public void EncryptCtr(ReadOnlySpan<byte> plaintext, Span<byte> destination)
    {
        var v1 = _var2 & 0xF;
        if (_var2 == 0 && _var1 != 0 && (_var1 & 0xF) != 0)
        {
            Aes.HarpoHash.Hash(_aes3.Span, _lutOwner.Memory.Span);
        }

        int v4 = 0;
        if (v1 != 0)
        {
            if (plaintext.Length != 0)
            {
                do
                {
                    if (v1 > 0xF) break;

                    byte v3 = (byte)(_aes2.Span[(int)v1] ^ plaintext[(int)v1]);
                    destination[(int)v1] = v3;
                    _aes3.Span[(int)v1] ^= v3;

                    v1++;
                } while (++v4 < plaintext.Length);
            }

            if (v1 == 0x10)
            {
                Aes.HarpoHash.Hash(_aes3.Span, _lutOwner.Memory.Span);
                v1 = 0;
            }
        }

        if (v4 + 0x10 <= plaintext.Length)
        {
            int outIndex = v4;
            do
            {
                IncrementCounter();

                EncryptEcb(plaintext: _counter.Span, ciphertext: _aes2.Span);
                Xor(destination.Slice(outIndex, 16), plaintext[v4..], _aes2.Span);
                Xor(_aes3.Span, _aes3.Span, destination.Slice(outIndex, 16));
                Aes.HarpoHash.Hash(_aes3.Span, _lutOwner.Memory.Span);

                outIndex += 0x10;
                v4 += 0x10;
            } while (outIndex + 0x10 <= plaintext.Length);
        }

        if (plaintext.Length > v4)
        {
            IncrementCounter();

            EncryptEcb(plaintext: _counter.Span, ciphertext: _aes2.Span);
            int aes3Index = (int)v1;
            int v2 = plaintext.Length - v4;
            int outIndex = v4;
            v4 += v2;

            do
            {
                byte aes2Byte = _aes2.Span[aes3Index];
                byte inputByte = plaintext[outIndex];

                destination[outIndex++] = (byte)(aes2Byte ^ inputByte);
                _aes3.Span[aes3Index++] ^= (byte)(aes2Byte ^ inputByte);
            } while (--v2 != 0);
        }

        _var2 += (uint)v4;
    }

    public bool CalculateChecksum(Span<byte> destination)
    {
        if (destination.Length >= 0x11)
        {
            throw new ArgumentException("Destination cannot be larger than 17 bytes", nameof(destination));
        }

        if (_var2 == 0 && _var1 != 0 && (_var1 & 0xF) != 0)
        {
            HarpoHash(_aes3);
        }

        if (_var2 != 0 && (_var2 & 0xF) != 0)
        {
            HarpoHash(_aes3);
        }

        var aes3 = _aes3.Span;

        // XOR with _var(s)
        uint v1 = _var2 << 3;
        for (int i = 0xF; i >= 0xC; i--)
        {
            aes3[i] ^= (byte)(v1 >> ((0xF - i) * 8));
        }

        aes3[0xB] ^= (byte)(_var2 >> 29);

        uint v2 = _var1 << 3;
        for (int i = 7; i >= 4; i--)
        {
            aes3[i] ^= (byte)(v2 >> ((7 - i) * 8));
        }

        aes3[3] ^= (byte)(_var1 >> 29);

        HarpoHash(aes3);

        // AES-Cipher the original iv extension (not the counter)
        EncryptEcb(_ivExtension.Span, _aes2.Span);

        // Write the checksum bytes (one checksum byte is _aes2[i] xor _aes3[i])
        int j = 0;
        var a = _aes2.Span;
        var b = _aes3.Span;
        do
        {
            destination[j] = (byte)(a[j] ^ b[j]);
        } while (++j < destination.Length);

        return true;
    }

    private void HarpoHash(Span<byte> data) =>
        Aes.HarpoHash.Hash(data, _lutOwner.Memory.Span);

    private void HarpoHash(Memory<byte> data) =>
        HarpoHash(data.Span);

    private void IncrementCounter()
    {
        int v2 = 0x10;
        do
        {
            if (v2 < 0xD) break;
            _counter.Span[--v2]++;
        } while (_counter.Span[v2] == 0);
    }

    private void Xor(Span<byte> destination, ReadOnlySpan<byte> a, ReadOnlySpan<byte> b)
    {
        Xor(MemoryMarshal.Cast<byte, uint>(destination), MemoryMarshal.Cast<byte, uint>(a),
            MemoryMarshal.Cast<byte, uint>(b));
    }

    public override void Dispose()
    {
        base.Dispose();
        _encryptionBufferOwner.Memory.Span.Clear();
        _lutOwner.Memory.Span.Clear();

        _encryptionBufferOwner.Dispose();
        _lutOwner.Dispose();
    }
}