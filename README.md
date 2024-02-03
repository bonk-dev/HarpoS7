![Logo](tools/padded-logo.png)

![GitHub License](https://img.shields.io/github/license/StereoKit/StereoKit)
![Codecov](https://img.shields.io/codecov/c/github/bonk-dev/HarpoS7?token=37FRE22MLI)
![GitHub top language](https://img.shields.io/github/languages/top/bonk-dev/HarpoS7)
![Nuget](https://img.shields.io/badge/nuget-Soon%E2%84%A2-yellow)


HarpoS7 is a C# library designed to authenticate sessions in the S7 Comm Plus protocol. It supports both **legacy
challenge** authentication (found in projects made using TIA Portal V16 and older) and the more recent TLS 
authentication introduced in project made using TIA Portal V17 and newer.

HarpoS7 is intended for integration into other libraries and frameworks rather than as a standalone tool 
for end users.

## Features
- Fully managed
- Supports challenge-based authentication (pre-V17 TIA portal)
- Supports TLS authentication (post-V17 TIA portal)

### Tested on
- S7-PLCSIM V16 (PLC: S7-1200)
- S7-PLCSIM V18 (PLC: S7-1500)

## Getting started
For a comprehensive example of how to use HarpoS7, explore the [HarpoS7.PoC](HarpoS7.PoC) project included in
the repository.

This project provides a hands-on demonstration of how to integrate HarpoS7 into a sample application. Follow 
the example code and comments to fully understand how to use the library.

### Public keys
If you are not using the S7-1200 provided by PLCSIM V16, you must extract the corresponding public keys used
by your selected PLC.

_TODO: Add a guide_

### Legacy auth sample
In order to authenticate a legacy session (challenge-based):
```csharp
// The "input" buffers - you have to load/fill them yourselves
// The "output" buffers - the library fills them

// Input - challenge received from the PLC (20 bytes long)
var challenge = new byte[20];

// Input - public key used by the PLC (loaded from local storage, 
// can be identified by the fingerprint sent by the PLC)
var publicKey = new byte[64];

// Output - "Encrypted key" which you send back to the PLC (216 bytes long)
var keyBlob = new byte[Constants.FinalBlobDataLength];

// Output - Session key used later on to calculate packet integrity hashes (24 bytes long)
var sessionKey = new byte[Constants.SessionKeyLength];

LegacyAuthenticationScheme.Authenticate(
    keyBlob.AsSpan(),
    sessionKey.AsSpan(),
    challenge.AsSpan(),
    publicKey.AsSpan());
```

In order to calculate a packet digest (these are used to prevent tampering):
```csharp
// Input - your packet data (without the S7-Header and S7-Trailer)
var data = new byte[dataLength];

// Input - session key (output from LegacyAuthenticationScheme.Authenticate)
var sessionKey = new byte[Constants.SessionKeyLength];

// Output - the packet data digest, usually placed in the S7-header
var digestBuffer = new byte[HarpoPacketDigest.DigestLength];

HarpoPacketDigest.CalculateDigest(digestBuffer.AsSpan(), data, sessionKey);
```

## TLS auth
It is important to note that although TLS authentication is present in HarpoS7, it should be treated as a proof
of concept rather than a ready-to-use solution. 

The reason is that the implementation is simply the built-in SslStream
wrapped around a primitive [CotpStream](HarpoS7/Transport/CotpStream.cs).

## Credits
- [Thomas_v2, Wireshark dissector plugin](https://sourceforge.net/projects/s7commwireshark/) - a Wireshark plugin used 
  for dissecting S7-Comm Plus packets.
- [Cheng Lei, Li Donghong, Ma Liang, The spear to break the security wall of S7CommPlus](https://www.blackhat.com/docs/eu-17/materials/eu-17-Lei-The-Spear-To-Break%20-The-Security-Wall-Of-S7CommPlus-wp.pdf) - a document describing the S7-Comm Plus protocol
- [Ghidra Software Reverse Engineering Framework](https://github.com/NationalSecurityAgency/ghidra) - "Ghidra is a software reverse engineering (SRE) framework created and maintained by the National Security Agency Research Directorate."