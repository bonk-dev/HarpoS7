namespace HarpoS7.Auth;

/// <summary>
/// Public key family (read from the ObjectVariableTypeName item from CreateObject response)
/// </summary>
public enum EPublicKeyFamily
{
    /// <summary>
    /// Used by S7-1500s
    /// </summary>
    Family0 = 0x00,
    
    /// <summary>
    /// Used by S7-1200s
    /// </summary>
    Family1 = 0x01,
    
    /// <summary>
    /// Used by PLCSIMs
    /// </summary>
    Family3 = 0x03
}