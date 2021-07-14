using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace IB.Api.Client.Streaming
{
    public class StreamingClient :IDisposable
    {
        public StreamingClient()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
