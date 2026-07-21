using HarpoS7.Auth;
using HarpoS7.PublicKeys.Impl;
using HarpoS7.Utilities.Auth;

const string fingerprint = "00:181B7B0847D11694";

var publicKeyStore = new DefaultPublicKeyStore();
var publicKey = new byte[publicKeyStore.GetPublicKeyLength(fingerprint)];
publicKeyStore.ReadPublicKey(publicKey, fingerprint);

var encryptedBlob = new byte[CommonConstants.EncryptedBlobLengthRealPlc];
var sessionKey = new byte[24];
LegacyAuthenticationScheme.AuthenticateRealPlc(
    encryptedBlob,
    sessionKey,
    new byte[20],
    publicKey,
    EPublicKeyFamily.S71500);

Console.WriteLine("HarpoS7 and HarpoS7.PublicKeys net48 package smoke test passed.");
