using System.Security.Cryptography;
using System.Text;
using HarpoS7.Extensions;
using HarpoS7.Fingerprint;

namespace HarpoS7.Keys;

public static class KeyUtilities
{
    private static readonly Memory<byte> DeriveKeyIdMagic;

    static KeyUtilities()
    {
        DeriveKeyIdMagic = new byte[6];
        Encoding.ASCII.GetBytes("DERIVE", DeriveKeyIdMagic.Span);
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
        Span<byte> digest = stackalloc byte[SHA256.HashSizeInBytes];
        digest.Clear();

        key[..keyPartLength].CopyTo(buffer);
        DeriveKeyIdMagic.Span.CopyTo(buffer[keyPartLength..]);

        _ = SHA256.HashData(buffer, digest);
        digest[..8].CopyTo(keyId);
    }

    public static void DeriveChallengeEncryptionKey(Span<byte> keyDestination, ReadOnlySpan<byte> randomKey)
    {
        if (randomKey.Length < 24)
        {
            throw new ArgumentException("The random key must be at least 24 bytes long");
        }

        if (keyDestination.Length < 16)
        {
            throw new ArgumentException("Key destination must be at least 16 bytes long");
        }

        Span<byte> plaintext = stackalloc byte[24 + 16];
        Span<byte> tempDigest = stackalloc byte[32];
            
        // 1. copy 24 bytes of the generated random
        randomKey[..24].CopyTo(plaintext);

        // 2. copy 16 byte magic
        var plaintextDword = plaintext[24..].AsDwords();
        plaintextDword[0] = 0x4030201U;
        plaintextDword[1] = 0x8070605U;
        plaintextDword[2] = 0xC0B0A09U;
        plaintextDword[3] = 0xF0E0DU;

        // 3. calculate the digest
        SHA256.HashData(plaintext, tempDigest);

        // 4. copy 16 bytes of the 32 byte digest
        tempDigest[..16].CopyTo(keyDestination);
    }

    /// <summary>
    /// Derives a key and initialization vector for encrypting the seed values with <see cref="HarpoS7.Aes.HarpoAes"/>
    /// </summary>
    /// <param name="destination">Destination for aesKey(32 bytes)+iv(16 bytes)</param>
    /// <param name="a2">Result of second <see cref="HarpoS7.Seed.HarpoSeedUtilities.SeedFunction2(Span{byte}, ReadOnlySpan{byte}, ReadOnlySpan{byte}, int)"/> call</param>
    /// <param name="a3">Reverse output of first <see cref="HarpoS7.Seed.HarpoSeedUtilities.SeedFunction2(Span{byte}, ReadOnlySpan{byte}, ReadOnlySpan{byte}, int)"/> call</param>
    /// <exception cref="ArgumentException"></exception>
    public static void DeriveSeedEncryptionKeyAndIv(Span<byte> destination, ReadOnlySpan<byte> a2,
        ReadOnlySpan<byte> a3)
    {
        if (destination.Length < 32 + 16)
        {
            throw new ArgumentException(
                "Destination must be at least 48 bytes long (key is 32 bytes and IV is 16 bytes)", nameof(destination));
        }

        if (a2.Length < 32)
        {
            throw new ArgumentException("A2 must be at least 32 bytes long", nameof(a2));
        }

        if (a3.Length < 64)
        {
            throw new ArgumentException("A3 must be at least 64 bytes long", nameof(a3));
        }

        Span<byte> v1 = stackalloc byte[32 + 64 + 1];
        Span<byte> tempDigest = stackalloc byte[32];

        a2[..32].ReverseBytes(v1);
        a3[..64].CopyTo(v1[32..]);

        byte offset = 0;
        do
        {
            v1[^1] = offset;
            _ = SHA256.HashData(v1, tempDigest);

            int size = (0x30 - offset < 0x20) ? 0x30 - offset : 0x20;
            tempDigest[..size].CopyTo(destination[offset..]);

            offset += 0x20;
        } while (0x30 - offset > 0);
        
        v1.Clear();
        tempDigest.Clear();
    }

    public static void DeriveSessionKey(Span<byte> sessionKeyDestination, ReadOnlySpan<byte> key1,
        ReadOnlySpan<byte> challenge)
    {
        if (challenge.Length < 18)
        {
            throw new ArgumentException("Challenge must be at least 18 bytes long (skipping 2 last bytes)",
                nameof(challenge));
        }

        if (key1.Length < 24)
        {
            throw new ArgumentException("Key1 must be at least 24 bytes long", nameof(key1));
        }

        if (sessionKeyDestination.Length < Constants.SessionKeyLength)
        {
            throw new ArgumentException("Session key destination must be at least 24 bytes long",
                nameof(sessionKeyDestination));
        }

        Span<byte> source = stackalloc byte[8 + 16];
        HarpoFingerprint.FingerprintChallenge(source[..8], challenge);

        challenge.Slice(2, 16).CopyTo(source[8..]);

        Span<byte> digestBuffer = stackalloc byte[HMACSHA256.HashSizeInBytes];
        HMACSHA256.HashData(key1[..24], source, digestBuffer);

        digestBuffer[..24].CopyTo(sessionKeyDestination);
    }
}