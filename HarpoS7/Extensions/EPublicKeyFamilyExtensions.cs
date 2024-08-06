using HarpoS7.Auth;

namespace HarpoS7.Extensions;

public static class EPublicKeyFamilyExtensions
{
    public static EPublicKeyFamily ToPublicKeyFamily(this string s) => 
        (EPublicKeyFamily)int.Parse(s[..2]);
}