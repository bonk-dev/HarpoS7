using System.Net.Security;
using System.Net.Sockets;
using HarpoS7.Tls;

var client = new TcpClient();
await client.ConnectAsync("192.168.1.76", 102);

var stream = client.GetStream();
var sslStream = await HarpoTlsAuth.AuthenticateUsingTlsAsync(stream, new SslClientAuthenticationOptions()
{
    RemoteCertificateValidationCallback = (_, _, _, _) => true,
    TargetHost = "192.168.1.76"
});

Console.WriteLine("Authed.");