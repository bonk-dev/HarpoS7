using System.Net.Security;
using HarpoS7.Transport;

namespace HarpoS7.Tls;

/// <summary>
/// Class responsible for authenticating your application using TLS (TIA Portal >= 17) 
/// </summary>
public static class HarpoTlsAuth
{
    private static readonly byte[] DiscardBuffer = new byte[128];
    
    private static readonly byte[] InitSslRequest =
    [
        0x72, 0x01, 0x00, 0x12, 0x31, 0x00, 0x00, 0x05, 0xB3, 0x00, 0x00, 0x00,
        0x01, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x00, 0x00, 0x00, 0x72, 0x01,
        0x00, 0x00
    ];
    
    public static async Task<SslStream> AuthenticateUsingTlsAsync(
        Stream stream, 
        SslClientAuthenticationOptions authOptions, 
        string destinationTsap = "SIMATIC-ROOT-HMI")
    {
        var cotpStream = new CotpStream(stream);
        await cotpStream.WriteConnectionRequestAsync(destinationTsap);
        await cotpStream.ReadConnectionConfirmAsync();

        await cotpStream.WriteAsync(InitSslRequest);
        _ = await stream.ReadAsync(DiscardBuffer); // discard InitSSL response
        
        await cotpStream.WriteEmptyDtDataAsync();

        var sslStream = new SslStream(cotpStream);
        await sslStream.AuthenticateAsClientAsync(authOptions);

        return sslStream;
    }
    
    public static async Task<SslStream> AuthenticateUsingTlsAsync(
        Stream stream, 
        string targetHost,
        string destinationTsap = "SIMATIC-ROOT-HMI")
    {
        var cotpStream = new CotpStream(stream);
        await cotpStream.WriteConnectionRequestAsync(destinationTsap);
        await cotpStream.ReadConnectionConfirmAsync();

        await cotpStream.WriteAsync(InitSslRequest);
        _ = await stream.ReadAsync(DiscardBuffer); // discard SSL response
        
        await cotpStream.WriteEmptyDtDataAsync();

        var sslStream = new SslStream(cotpStream);
        await sslStream.AuthenticateAsClientAsync(targetHost);

        return sslStream;
    }
}