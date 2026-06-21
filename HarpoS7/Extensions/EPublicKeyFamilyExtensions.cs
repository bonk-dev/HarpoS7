using HarpoS7.Auth;
using HarpoS7.Utilities.Auth;

namespace HarpoS7.Extensions;

public static class EPublicKeyFamilyExtensions
{
    public static EPublicKeyFamily ToPublicKeyFamily(this string s)
    {
        if (string.IsNullOrWhiteSpace(s) || s.Length < 2 || !int.TryParse(s[..2], out var family))
        {
            throw new ArgumentException("Fingerprint must start with a two-digit Siemens OMS key-family prefix.", nameof(s));
        }

        if (!Enum.IsDefined(typeof(EPublicKeyFamily), family))
        {
            throw new ArgumentException($"Unsupported Siemens OMS key-family prefix '{s[..2]}'.", nameof(s));
        }

        return (EPublicKeyFamily)family;
    }

    public static string GetSiemensFamilyName(this EPublicKeyFamily family) =>
        SiemensCsiKeyFlags.GetSiemensFamilyName(family);
}
