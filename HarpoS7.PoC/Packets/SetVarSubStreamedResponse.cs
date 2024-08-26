using HarpoS7.PoC.Models;

namespace HarpoS7.PoC.Packets;

public class SetVarSubStreamedResponse
{
    private const int ReturnValueOffset = 0x36;
    
    public EStatusCode StatusCode { get; set; } 
    
    public SetVarSubStreamedResponse(ReadOnlySpan<byte> packet)
    {
        var returnValue = packet[ReturnValueOffset..].DecodeAsVlq64(out _);
        StatusCode = (EStatusCode)(int)(returnValue & 0b11111111_11111111);
    }
}