using System.Security.Cryptography;
using System.Text;
using HarpoS7.Utilities.Compatibility;

namespace HarpoS7.Utilities.Extensions;

public static class KeyExtensions
{
    private static readonly Memory<byte> DeriveKeyIdMagic;

    static KeyExtensions()
    {
        DeriveKeyIdMagic = new byte[6];
        Encoding.ASCII.GetBytes("DERIVE").AsSpan().CopyTo(DeriveKeyIdMagic.Span);
    }

    public static void DeriveKeyId(this byte[] key, Span<byte> keyId) =>
        key.AsSpan().DeriveKeyId(keyId);

    public static void DeriveKeyId(this Span<byte> key, Span<byte> keyId) =>
        ((ReadOnlySpan<byte>)key).DeriveKeyId(keyId);

    public static void DeriveKeyId(this ReadOnlySpan<byte> key, Span<byte> keyId)
    {
        const int keyIdLength = 8;
        const int keyPartLength = 24;

        if (keyId.Length < keyIdLength)
        {
            throw new ArgumentException($"Key id span must be at least {keyIdLength} bytes long", nameof(keyId));
        }

        if (key.Length < keyPartLength)
        {
            throw new ArgumentException($"Key span must be at least {keyPartLength} bytes long", nameof(keyId));
        }
        
        // no need to clear the "buffer", it is overwritten anyway
        Span<byte> buffer = stackalloc byte[keyPartLength + DeriveKeyIdMagic.Length];
        Span<byte> digest = stackalloc byte[CryptoCompatibility.Sha256HashSizeInBytes];
        digest.Clear();

        key[..keyPartLength].CopyTo(buffer);
        DeriveKeyIdMagic.Span.CopyTo(buffer[keyPartLength..]);

        CryptoCompatibility.Sha256(buffer, digest);
        digest[..8].CopyTo(keyId);
    }
}
