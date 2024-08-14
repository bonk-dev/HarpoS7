namespace HarpoS7.Utilities.Auth;

/// <summary>
/// Public key family (read from the ObjectVariableTypeName item from CreateObject response)
/// </summary>
public enum EPublicKeyFamily
{
    /// <summary>
    /// Used by S7-1500s
    /// </summary>
    S71500 = 0x00,
    
    /// <summary>
    /// Used by S7-1200s
    /// </summary>
    S71200 = 0x01,
    
    /// <summary>
    /// Used by PLCSIMs
    /// </summary>
    PlcSim = 0x03
}