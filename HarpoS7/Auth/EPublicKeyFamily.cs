namespace HarpoS7.Auth;

/// <summary>
/// Public key family (read from the ObjectVariableTypeName item from CreateObject response)
/// </summary>
public enum EPublicKeyFamily
{
    /// <summary>
    /// Used by real PLCs
    /// </summary>
    Family0 = 0x00,
    
    /// <summary>
    /// Used by PLCSIM
    /// </summary>
    Family3 = 0x03
}