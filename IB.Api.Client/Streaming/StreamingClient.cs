using System;
using System.Net;
using System.Net.Security;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Websocket.Client;
using Websocket.Client.Models;

namespace IB.Api.Client.Streaming
{
    public class StreamingClient : IDisposable
    {
        private Uri _url;
        private WebsocketClient _client;
        private ManualResetEvent _exitEvent;
        public event EventHandler<ReconnectionInfo> OnReconnectionHappened;
        public event EventHandler<ResponseMessage> OnMessageReceived;

        public StreamingClient()
        {
            _url = new Uri("wss://localhost:5000/v1/api/ws");

            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
                
            var factory = new Func<ClientWebSocket>(() => new ClientWebSocket
            {
                Options =
                {
                    RemoteCertificateValidationCallback = (message, cert, chain, sslPolicyErrors) =>
                    {
                        return true;
                    }
                }
            });

            _exitEvent = new ManualResetEvent(false);
            _client = new WebsocketClient(_url, factory);
            _client.ReconnectTimeout = TimeSpan.FromSeconds(30);

            _client.ReconnectionHappened.Subscribe(info => OnReconnectionHappened?.Invoke(this, info));
            _client.MessageReceived.Subscribe(msg => OnMessageReceived?.Invoke(this, msg));
        }

        public void Dispose()
        {
            _client.Dispose();
            this.Dispose();
        }
    }
}
