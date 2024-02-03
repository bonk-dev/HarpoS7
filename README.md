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

## TLS auth
It is important to note that although TLS authentication is present in HarpoS7, it should be treated as a proof
of concept rather than a ready-to-use solution. 

The reason is that the implementation is simply the built-in SslStream
wrapped around a primitive [CotpStream](HarpoS7/Transport/CotpStream.cs).

## Credits
- [Thomas_v2, Wireshark dissector plugin](https://sourceforge.net/projects/s7commwireshark/) - a Wireshark plugin used 
  for dissecting S7-Comm Plus packets.
- [Cheng Lei, Li Donghong, Ma Liang, The spear to break the security wall of S7CommPlus](https://www.blackhat.com/docs/eu-17/materials/eu-17-Lei-The-Spear-To-Break%20-The-Security-Wall-Of-S7CommPlus-wp.pdf) - a document describing the S7-Comm Plus protocol