using System;
using System.Net;
using System.Net.Security;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IB.Api.Client.Streaming
{
    public class StreamingClient : IDisposable
    {
        private Uri _url;
        ClientWebSocket _client;
        public event EventHandler<string> OnMessageReceived;

        public StreamingClient()
        {
            _url = new Uri("wss://localhost:5000/v1/api/ws");

            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
            _client = new ClientWebSocket();
            _client.Options.RemoteCertificateValidationCallback = (message, cert, chain, sslPolicyErrors) =>
                   {
                       return true;
                   };
        }
        public async Task Connect()
        {
            await _client.ConnectAsync(_url, CancellationToken.None);
        }
        public async Task SendMessage(string message)
        {
            var encoded = Encoding.UTF8.GetBytes(message);
            var buffer = new ArraySegment<Byte>(encoded, 0, encoded.Length);
            await _client.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
            Console.WriteLine($"Message sent: {message}");
        }
        public async Task SubcribeToMesssages() => await Receive();
        private async Task Receive()
        {
            while (_client.State == WebSocketState.Open)
            {
                var bytesReceived = new ArraySegment<byte>(new byte[1024]);
                var result = await _client.ReceiveAsync(bytesReceived, CancellationToken.None);
                var message = Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count);
                OnMessageReceived?.Invoke(this, message);
            }
        }
        public void Dispose()
        {
            _client.Dispose();
            this.Dispose();
        }
    }
}
