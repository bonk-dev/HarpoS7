using System.Net;
using System.Net.Sockets;
using System.Text;
using HarpoS7;
using HarpoS7.Auth;
using HarpoS7.Extensions;
using HarpoS7.PoC;
using HarpoS7.PoC.Packets;
using HarpoS7.PublicKeys.Exceptions;
using HarpoS7.PublicKeys.Impl;
using HarpoS7.Utilities.Auth;
using HarpoS7.Utilities.Extensions;

// All "requests" were extracted from a Wireshark dump
// in a real library/app you would obviously serialize/deserialize these dynamically

var readBuffer = new byte[1024];
if (args.Length < 1 || !IPEndPoint.TryParse(args[0], out var endPoint))
{
    Console.WriteLine("Usage: HarpoS7.PoC ip_address:port [optional access password]");
    Console.WriteLine("Example (no password): HarpoS7.PoC 192.168.1.10:102");
    Console.WriteLine("Example (w. password): HarpoS7.PoC 192.168.1.10:102 \"zaq1@WSX\"");
    
    return;
}

// Connect to the PLC
using var client = new TcpClient();

try
{
	await client.ConnectAsync(endPoint);
}
catch (SocketException ex)
{
	Console.WriteLine($"[-] Could not connect to {endPoint}");
	Console.WriteLine($"[-] Exception message: {ex.Message}");

	return;
}

Console.WriteLine($"[+] Connected to {endPoint}");
var stream = client.GetStream();

// Send COTP Connection Request
var cotpConnectionRequest = new byte[] 
{
    0x03, 0x00, 0x00, 0x24, 0x1F, 0xE0, 0x00, 0x00, 0x00, 0x01, 0x00, 0xC1,
    0x02, 0x06, 0x00, 0xC2, 0x10, 0x53, 0x49, 0x4D, 0x41, 0x54, 0x49, 0x43,
    0x2D, 0x52, 0x4F, 0x4F, 0x54, 0x2D, 0x48, 0x4D, 0x49, 0xC0, 0x01, 0x0A
};

Console.WriteLine("Sending COTP CR...");
await stream.WriteAsync(cotpConnectionRequest);

Console.WriteLine("Waiting for COTP Connection Confirm");
_ = await stream.ReadAsync(readBuffer);

// write empty DT-Data
var emptyDtData = new byte[]
{
	0x03, 0x00, 0x00, 0x07, 0x02, 0xF0, 0x00
};
await stream.WriteAsync(emptyDtData);

// Send S7CommPlus CreateObject request (creates a session object on the PLC)
var createObjectRequest = new byte[] 
{
	0x03, 0x00, 0x01, 0x10, 0x02, 0xF0, 0x80, 0x72, 0x01, 0x01, 0x01, 0x31,
	0x00, 0x00, 0x04, 0xCA, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x01, 0x20,
	0x36, 0x00, 0x00, 0x01, 0x1D, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00,
	0xA1, 0x00, 0x00, 0x00, 0xD3, 0x82, 0x1F, 0x00, 0x00, 0xA3, 0x81, 0x69,
	0x00, 0x15, 0x15, 0x53, 0x65, 0x72, 0x76, 0x65, 0x72, 0x53, 0x65, 0x73,
	0x73, 0x69, 0x6F, 0x6E, 0x5F, 0x31, 0x43, 0x39, 0x43, 0x33, 0x38, 0x31,
	0xA3, 0x82, 0x21, 0x00, 0x15, 0x41, 0x30, 0x3A, 0x3A, 0x3A, 0x36, 0x2E,
	0x30, 0x3A, 0x3A, 0x41, 0x53, 0x49, 0x58, 0x20, 0x41, 0x58, 0x38, 0x38,
	0x31, 0x37, 0x39, 0x20, 0x55, 0x53, 0x42, 0x20, 0x33, 0x2E, 0x30, 0x20,
	0x74, 0x6F, 0x20, 0x47, 0x69, 0x67, 0x61, 0x62, 0x69, 0x74, 0x20, 0x45,
	0x74, 0x68, 0x65, 0x72, 0x6E, 0x65, 0x74, 0x20, 0x41, 0x64, 0x61, 0x70,
	0x74, 0x65, 0x72, 0x2E, 0x54, 0x43, 0x50, 0x49, 0x50, 0x2E, 0x31, 0xA3,
	0x82, 0x28, 0x00, 0x15, 0x0A, 0x52, 0x65, 0x61, 0x64, 0x20, 0x57, 0x72,
	0x69, 0x74, 0x65, 0xA3, 0x82, 0x29, 0x00, 0x15, 0x0B, 0x48, 0x4D, 0x49,
	0x20, 0x52, 0x54, 0x20, 0x4F, 0x4D, 0x53, 0x2B, 0xA3, 0x82, 0x2A, 0x00,
	0x15, 0x08, 0x59, 0x6F, 0x75, 0x72, 0x48, 0x6F, 0x73, 0x74, 0xA3, 0x82,
	0x2B, 0x00, 0x04, 0x02, 0xA3, 0x82, 0x2C, 0x00, 0x12, 0x01, 0xC9, 0xC3,
	0x81, 0xA3, 0x82, 0x2D, 0x00, 0x15, 0x0F, 0x52, 0x65, 0x61, 0x64, 0x2F,
	0x57, 0x72, 0x69, 0x74, 0x65, 0x20, 0x74, 0x61, 0x67, 0x73, 0xA1, 0x00,
	0x00, 0x00, 0xD3, 0x81, 0x7F, 0x00, 0x00, 0xA3, 0x81, 0x69, 0x00, 0x15,
	0x15, 0x53, 0x75, 0x62, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6F,
	0x6E, 0x43, 0x6F, 0x6E, 0x74, 0x61, 0x69, 0x6E, 0x65, 0x72, 0xA2, 0xA2,
	0x00, 0x00, 0x00, 0x00, 0x72, 0x01, 0x00, 0x00
};

Console.WriteLine("Creating a session object");
await stream.WriteAsync(createObjectRequest);

Console.WriteLine("Waiting for create object response");
_ = await stream.ReadAsync(readBuffer);

await stream.WriteAsync(emptyDtData);

// read the public key fingerprint
// the string length is serialized as a VLQ-encoded number

const int plcSimPacketFingerprintLengthOffset = 0x37;
const int realPlcPacketFingerprintLengthOffset = 0x2F;

// max length of a 32-bit VLQ number is 5 (4+1) bytes
var fingerprintLength = Vlq.DecodeAsVlq32(readBuffer.AsSpan(plcSimPacketFingerprintLengthOffset, 5), out var vlqLength);
var fingerprintValueOffset = plcSimPacketFingerprintLengthOffset + vlqLength;

var fingerprintStringBytes = readBuffer.AsMemory(fingerprintValueOffset, (int)fingerprintLength);
var fingerprintString = Encoding.UTF8.GetString(fingerprintStringBytes.Span);

if (!fingerprintString.StartsWith("03:") && !fingerprintString.StartsWith("00:") && !fingerprintString.StartsWith("01:"))
{
    Console.WriteLine("[?] Fingerprint does not start with 03:, checking family0/1 offset...");
    
    fingerprintLength = Vlq.DecodeAsVlq32(readBuffer.AsSpan(realPlcPacketFingerprintLengthOffset, 5), out vlqLength);
    fingerprintValueOffset = realPlcPacketFingerprintLengthOffset + vlqLength;

    fingerprintStringBytes = readBuffer.AsMemory(fingerprintValueOffset, (int)fingerprintLength);
    fingerprintString = Encoding.UTF8.GetString(fingerprintStringBytes.Span);

    if (!fingerprintString.StartsWith("03:") && !fingerprintString.StartsWith("00:") && !fingerprintString.StartsWith("01:"))
    {
        Console.WriteLine(Convert.ToHexString(fingerprintStringBytes.ToArray()));
        Console.WriteLine("[-] Fingerprint does not start with 03: nor with 00:. Exiting");
        return;
    }

    Console.WriteLine("[+] Family0/1 fingerprint found");
}

// again, you would normally deserialize the response packet
// and read the challenge array safely, instead of relying on byte offsets
var rawChallengeArrayOffset = fingerprintString.StartsWith("03:") ? 0x7D : 0x75;
const int rawChallengeArrayLength = 20;

// read the 20-long byte buffer (the challenge)
var challenge = readBuffer.AsMemory(rawChallengeArrayOffset, rawChallengeArrayLength);
Console.Write("Challenge: ");
Helpers.PrintBuffer(challenge);

Console.WriteLine($"Reversed fingerprint: {fingerprintString}");

// reverse string and parse fingerprint
var publicKeyFingerprint = new byte[Constants.KeyIdLength];
Helpers.ParseAndReverseBytes(fingerprintString, publicKeyFingerprint);

Console.Write("Actual fingerprint: ");
Helpers.PrintBuffer(publicKeyFingerprint);

// get the matching public key from the KeyStore
var store = new DefaultPublicKeyStore();
var publicKey = new byte[store.GetPublicKeyLength(fingerprintString)];

try
{
    store.ReadPublicKey(publicKey.AsSpan(), fingerprintString);
}
catch (UnknownPublicKeyException)
{
    Console.WriteLine("[-] Public key for this fingerprint was not found in the key store. " +
                      "You need to find the appropriate key and add it to the key store.");
    return;
}

Console.WriteLine("[+] Public key found");

// create buffers
var sessionKey = new byte[Constants.SessionKeyLength];
var keyBlob = new byte[fingerprintString.StartsWith("03:") ? CommonConstants.EncryptedBlobLengthPlcSim : CommonConstants.EncryptedBlobLengthRealPlc];

Console.WriteLine("Doing the encryption...");

var publicKeyFamily = fingerprintString.ToPublicKeyFamily();

// auth locally
LegacyAuthenticationScheme.Authenticate(
    keyBlob.AsSpan(),
    sessionKey.AsSpan(),
    challenge.Span,
    publicKey.AsSpan(),
    publicKeyFamily
);

// construct metadata
var pubKeyId = new byte[Constants.KeyIdLength];
var sessionKeyId = new byte[Constants.KeyIdLength];

publicKey.DeriveKeyId(pubKeyId);
sessionKey.DeriveKeyId(sessionKeyId);

var setMultiVarsRequest = new SetMultiVarsRequest(
    pubKeyId,
    sessionKeyId,
    keyBlob.AsSpan()
);

// send request
Console.WriteLine("Sending a set multi vars request");

switch (publicKeyFamily)
{
    case EPublicKeyFamily.S71500:
        setMultiVarsRequest.WriteS71500(stream);
        break;
    case EPublicKeyFamily.S71200:
        setMultiVarsRequest.WriteS71200(stream);
        break;
    case EPublicKeyFamily.PlcSim:
        setMultiVarsRequest.WritePlcSim(stream);
        break;
    default:
        throw new Exception("setMultiVarsRequest: Unsupported public key family");
}

var tokenSource = new CancellationTokenSource();
tokenSource.CancelAfter(3000);
Console.WriteLine("Waiting for a set var response...");

int read;
try
{
	read = await stream.ReadAsync(readBuffer, tokenSource.Token);
}
catch (OperationCanceledException)
{
	Console.WriteLine("[-] No response after 3000 ms - authentication failed");
	return;
}

if (read <= 0)
{
	Console.WriteLine("[-] The PLC sent an empty response");
	return;
}

// an approximation of the return value field (should be all 0x00).
// I might have included the integrity id field or the unknown field by accident;
// these should be all 0x00 anyway.
const int returnValueOffset = 0x15;
const int returnValueLength = 7;
for (var i = returnValueOffset; i < returnValueOffset + returnValueLength; ++i)
{
	if (readBuffer[i] != 0x00)
	{
		Console.WriteLine("[-] Looks like an error has occured. Check if the ReturnValue field is 0x00 (OK)");
		return;
	}
}

Console.WriteLine("[++] Success! Looks like the authentication was successful. Check the packet dump (e.g. in Wireshark) to be sure.");

if (args.Length <= 1)
{
    return;
}
if (publicKeyFamily != EPublicKeyFamily.S71200)
{
    Console.WriteLine("[-] Legitimation is currently only supported on S7-1200s");
    return;
}

var accessPassword = args[1];
Console.WriteLine($"Trying to legitimate the session with a password (\"{accessPassword}\")");

Console.WriteLine("Requesting the legitimation challenge");
var subStreamRequest = new GetVarSubStreamedRequest(sessionKey.AsSpan());
subStreamRequest.WriteS71200(stream);

tokenSource = new CancellationTokenSource();
tokenSource.CancelAfter(3000);
Console.WriteLine("Waiting for the challenge...");

try
{
    read = await stream.ReadAsync(readBuffer, tokenSource.Token);
}
catch (OperationCanceledException)
{
    Console.WriteLine("[-] No response after 3000 ms - legitimation failed");
    return;
}

const int realPlcLegitimationChallengeOffset = 0x3B;
var legitimationChallenge = readBuffer.AsSpan(realPlcLegitimationChallengeOffset, 20).ToArray();

Console.Write("[+] Legitimation challenge: ");
Helpers.PrintBuffer(legitimationChallenge);

Console.WriteLine("Solving the legitimation challenge...");

var legitBlob = new byte[CommonConstants.EncryptedLegitimationBlobLengthRealPlc]; 
LegitimateScheme.SolveLegitimateChallengeRealPlc(
    legitBlob.AsSpan(),
    legitimationChallenge.AsSpan(),
    publicKey.AsSpan(),
    publicKeyFamily,
    sessionKey.AsSpan(),
    accessPassword
);

Console.WriteLine("Challenge solved");
Console.WriteLine("Sending the SetVarSubStreamed request...");

var legitSetChallenge = new SetVarSubStreamedRequest(sessionKey, legitBlob);
legitSetChallenge.WriteS71200(stream);

await stream.WriteAsync(emptyDtData);

tokenSource = new CancellationTokenSource();
tokenSource.CancelAfter(3000);
Console.WriteLine("Waiting for the response...");

try
{
    read = await stream.ReadAsync(readBuffer, tokenSource.Token);
}
catch (OperationCanceledException)
{
    Console.WriteLine("[-] No response after 3000 ms - legitimation failed");
    return;
}

// TODO: Check response