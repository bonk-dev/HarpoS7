namespace HarpoS7.Utilities.Auth;

/// <summary>
/// Public key family prefix read from the ServerSession ObjectVariableTypeName
/// fingerprint in the CreateObject response.
/// </summary>
public enum EPublicKeyFamily
{
    /// <summary>
    /// Siemens OMS <c>KeyFamilyCPU1500</c>; fingerprint prefix <c>00</c>.
    /// </summary>
    S71500 = 0x00,
    
    /// <summary>
    /// Siemens OMS <c>KeyFamilyCPU1200</c>; fingerprint prefix <c>01</c>.
    /// </summary>
    S71200 = 0x01,
    
    /// <summary>
    /// Siemens OMS <c>KeyFamilyVPLC</c>; fingerprint prefix <c>03</c>. Used by PLCSIM/VPLC targets.
    /// </summary>
    PlcSim = 0x03
}
