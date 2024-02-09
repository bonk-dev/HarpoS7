namespace HarpoS7.KeyDumper.Models;

/// <summary>
/// Key data from the HWCN/Custom/Keys directory
/// <para>Does not include buffers used to verify the validity of this key</para>
/// </summary>
/// <param name="Version"></param>
/// <param name="OrderNumber"></param>
/// <param name="FirmwareVersion"></param>
/// <param name="Type"></param>
/// <param name="FamilyType"></param>
/// <param name="KeyData64"></param>
/// <param name="Certificate64"></param>
/// <param name="Signature64"></param>>
public record KeyData(
    int Version, 
    string OrderNumber, 
    string FirmwareVersion, 
    EKeyType Type, 
    EKeyFamilyType FamilyType, 
    string KeyData64,
    string Certificate64,
    string Signature64);