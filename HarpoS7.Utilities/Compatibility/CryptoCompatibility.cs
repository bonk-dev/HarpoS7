using System.Security.Cryptography;

namespace HarpoS7.Utilities.Compatibility;

internal static class CryptoCompatibility
{
    public const int Sha256HashSizeInBytes = 32;
    public const int Sha1HashSizeInBytes = 20;

    public static void FillRandom(Span<byte> destination)
    {
#if NETSTANDARD2_0
        var randomBytes = new byte[destination.Length];
        using (var randomNumberGenerator = RandomNumberGenerator.Create())
        {
            randomNumberGenerator.GetBytes(randomBytes);
        }

        randomBytes.AsSpan().CopyTo(destination);
#else
        RandomNumberGenerator.Fill(destination);
#endif
    }

    public static void Sha256(ReadOnlySpan<byte> source, Span<byte> destination)
    {
        if (destination.Length < Sha256HashSizeInBytes)
        {
            throw new ArgumentException($"Destination must be at least {Sha256HashSizeInBytes} bytes long", nameof(destination));
        }

#if NETSTANDARD2_0
        using (var sha256 = SHA256.Create())
        {
            sha256.ComputeHash(source.ToArray()).AsSpan().CopyTo(destination);
        }
#else
        SHA256.HashData(source, destination);
#endif
    }

    public static void Sha1(ReadOnlySpan<byte> source, Span<byte> destination)
    {
        if (destination.Length < Sha1HashSizeInBytes)
        {
            throw new ArgumentException($"Destination must be at least {Sha1HashSizeInBytes} bytes long", nameof(destination));
        }

#if NETSTANDARD2_0
        using (var sha1 = SHA1.Create())
        {
            sha1.ComputeHash(source.ToArray()).AsSpan().CopyTo(destination);
        }
#else
        SHA1.HashData(source, destination);
#endif
    }

    public static void HmacSha256(ReadOnlySpan<byte> key, ReadOnlySpan<byte> source, Span<byte> destination)
    {
        if (destination.Length < Sha256HashSizeInBytes)
        {
            throw new ArgumentException($"Destination must be at least {Sha256HashSizeInBytes} bytes long", nameof(destination));
        }

#if NETSTANDARD2_0
        using (var hmacSha256 = new HMACSHA256(key.ToArray()))
        {
            hmacSha256.ComputeHash(source.ToArray()).AsSpan().CopyTo(destination);
        }
#else
        HMACSHA256.HashData(key, source, destination);
#endif
    }

    public static void EncryptEcb(
        System.Security.Cryptography.Aes aes,
        ReadOnlySpan<byte> plaintext,
        Span<byte> ciphertext,
        PaddingMode paddingMode = PaddingMode.None)
    {
        if (plaintext.IsEmpty)
        {
            return;
        }

#if NETSTANDARD2_0
        var blockSize = aes.BlockSize / 8;
        if (paddingMode == PaddingMode.None && plaintext.Length % blockSize != 0)
        {
            throw new CryptographicException("Plaintext length must be a multiple of the AES block size when padding is disabled");
        }

        var encryptedLength = paddingMode == PaddingMode.None
            ? plaintext.Length
            : ((plaintext.Length + blockSize - 1) / blockSize) * blockSize;
        if (ciphertext.Length < encryptedLength)
        {
            throw new ArgumentException($"Destination must be at least {encryptedLength} bytes long", nameof(ciphertext));
        }

        var input = new byte[encryptedLength];
        plaintext.CopyTo(input);
        var originalMode = aes.Mode;
        var originalPadding = aes.Padding;

        try
        {
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.None;

            using (var encryptor = aes.CreateEncryptor())
            {
                var output = encryptor.TransformFinalBlock(input, 0, input.Length);
                output.AsSpan().CopyTo(ciphertext);
            }
        }
        finally
        {
            aes.Mode = originalMode;
            aes.Padding = originalPadding;
        }
#else
        aes.EncryptEcb(plaintext, ciphertext, paddingMode);
#endif
    }
}
