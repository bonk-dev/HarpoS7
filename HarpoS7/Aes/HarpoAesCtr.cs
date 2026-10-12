using System.Buffers.Binary;

namespace HarpoS7.Aes;

/// <summary>AES-GCM without AAD, with Siemens' 24-bit counter increment.</summary>
public class HarpoAesCtr : HarpoAes
{
    private readonly byte[] _hashKey = new byte[16];
    private readonly byte[] _initialCounter = new byte[16];
    private readonly byte[] _counter = new byte[16];
    private readonly byte[] _keystream = new byte[16];
    private readonly byte[] _hash = new byte[16];
    private int _blockOffset;
    private ulong _ciphertextLength;

    public HarpoAesCtr(ReadOnlySpan<byte> key) : base(key) { }

    public void Init(ReadOnlySpan<byte> iv)
    {
        Span<byte> h = stackalloc byte[16];
        h.Clear();
        EncryptEcb(h, h);
        h.CopyTo(_hashKey);
        Array.Clear(_initialCounter, 0, 16);
        if (iv.Length == 12)
        {
            iv.CopyTo(_initialCounter);
            _initialCounter[15] = 1;
        }
        else
        {
            for (var offset = 0; offset < iv.Length; offset += 16)
            {
                var count = Math.Min(16, iv.Length - offset);
                for (var i = 0; i < count; i++) _initialCounter[i] ^= iv[offset + i];
                HarpoHash.Multiply(_initialCounter, _hashKey);
            }
            Span<byte> length = stackalloc byte[16];
            length.Clear();
            BinaryPrimitives.WriteUInt64BigEndian(length.Slice(8), (ulong)iv.Length * 8);
            for (var i = 0; i < 16; i++) _initialCounter[i] ^= length[i];
            HarpoHash.Multiply(_initialCounter, _hashKey);
        }
        _initialCounter.CopyTo(_counter, 0);
        Array.Clear(_hash, 0, 16);
        Array.Clear(_keystream, 0, 16);
        _blockOffset = 0;
        _ciphertextLength = 0;
    }

    public void EncryptCtr(ReadOnlySpan<byte> plaintext, Span<byte> destination)
    {
        if (destination.Length < plaintext.Length) throw new ArgumentException("Destination is too short", nameof(destination));
        for (var i = 0; i < plaintext.Length; i++)
        {
            if (_blockOffset == 0)
            {
                // Carry is deliberately limited to bytes 13..15 by the protocol.
                for (var j = 15; j >= 13; j--) if (++_counter[j] != 0) break;
                EncryptEcb(_counter, _keystream);
            }
            var ciphertext = (byte)(plaintext[i] ^ _keystream[_blockOffset]);
            destination[i] = ciphertext;
            _hash[_blockOffset] ^= ciphertext;
            _blockOffset++;
            if (_blockOffset == 16)
            {
                HarpoHash.Multiply(_hash, _hashKey);
                _blockOffset = 0;
            }
        }
        _ciphertextLength += (ulong)plaintext.Length;
    }

    public bool CalculateChecksum(Span<byte> destination)
    {
        if (destination.Length > 16) throw new ArgumentException("Checksum cannot be longer than 16 bytes", nameof(destination));
        Span<byte> hash = stackalloc byte[16];
        _hash.AsSpan().CopyTo(hash);
        if (_blockOffset != 0) HarpoHash.Multiply(hash, _hashKey);
        Span<byte> length = stackalloc byte[16];
        length.Clear();
        BinaryPrimitives.WriteUInt64BigEndian(length.Slice(8), _ciphertextLength * 8);
        for (var i = 0; i < 16; i++) hash[i] ^= length[i];
        HarpoHash.Multiply(hash, _hashKey);
        Span<byte> mask = stackalloc byte[16];
        EncryptEcb(_initialCounter, mask);
        for (var i = 0; i < destination.Length; i++) destination[i] = (byte)(hash[i] ^ mask[i]);
        return true;
    }

    public override void Dispose()
    {
        base.Dispose();
        Array.Clear(_hashKey, 0, _hashKey.Length);
        Array.Clear(_initialCounter, 0, 16);
        Array.Clear(_counter, 0, 16);
        Array.Clear(_keystream, 0, 16);
        Array.Clear(_hash, 0, 16);
    }
}
