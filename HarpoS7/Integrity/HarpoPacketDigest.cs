using System.Security.Cryptography;

namespace HarpoS7.Integrity;

/// <summary>
/// A wrapper for the <see cref="HMACSHA256"/>
/// </summary>
public static class HarpoPacketDigest
{
    /// <summary>
    /// Length of the calculated packet digest (in bytes)
    /// </summary>
    public const int DigestLength = 32;

    /// <summary>
    /// Calculates the digest for verifying the integrity of a S7CommPlus packet.
    /// </summary>
    /// <param name="destination">The destination of the digest</param>
    /// <param name="data">The packet data</param>
    /// <param name="sessionKey">The session key (see: <see cref="HarpoS7.Keys.KeyUtilities.DeriveSessionKey"/>)</param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static void CalculateDigest(Span<byte> destination, ReadOnlySpan<byte> data, ReadOnlySpan<byte> sessionKey)
    {
        if (destination.Length < DigestLength)
        {
            throw new ArgumentException($"Destination must be at least {DigestLength} bytes long (actual length: {destination.Length}",
                nameof(destination));
        }
        if (sessionKey.Length < Constants.SessionKeyLength)
        {
            throw new ArgumentException($"Session key must be at least {Constants.SessionKeyLength} bytes long (actual length: {sessionKey.Length})",
                nameof(sessionKey));
        }

        if (!HMACSHA256.TryHashData(sessionKey[..Constants.SessionKeyLength], data, destination, out var bytesWritten))
        {
            throw new Exception("Could not calculate the packet digest");
        }

        if (bytesWritten != DigestLength)
        {
            throw new Exception($"Calculated digest length ({bytesWritten}) did not match the expected length ({DigestLength})");
        }
    }
}