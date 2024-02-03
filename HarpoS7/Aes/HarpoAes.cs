using MsAes = System.Security.Cryptography.Aes;
using System.Security.Cryptography;

namespace HarpoS7.Aes;

public class HarpoAes : IDisposable
{
    protected MsAes AesCrypt { get; }

    public HarpoAes(ReadOnlySpan<byte> key)
    {
        if (key.Length != 128 / 8)
        {
            throw new ArgumentException(
                $"Harpo AES uses only 128bit keys (16 bytes), while the provided key is {key.Length} bytes long",
                nameof(key));
        }

        AesCrypt = MsAes.Create();
        AesCrypt.BlockSize = 128;
        AesCrypt.KeySize = 128;
        AesCrypt.Mode = CipherMode.ECB;
        AesCrypt.Padding = PaddingMode.Zeros;

        byte[] zeroIv = new byte[16];
        AesCrypt.IV = zeroIv;
        AesCrypt.Key = key.ToArray();
    }

    public void EncryptEcb(ReadOnlySpan<byte> plaintext, Span<byte> ciphertext)
    {
        AesCrypt.EncryptEcb(plaintext, ciphertext, PaddingMode.Zeros);
    }

    public void Xor(Span<uint> output, ReadOnlySpan<uint> a, ReadOnlySpan<uint> b)
    {
        for (int i = 0; i < output.Length; ++i)
        {
            output[i] = a[i] ^ b[i];
        }
    }

    public virtual void Dispose()
    {
        AesCrypt.Dispose();
    }
}