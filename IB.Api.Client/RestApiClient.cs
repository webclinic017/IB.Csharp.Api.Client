using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using IB.Api.Client.Response;
using Newtonsoft.Json;

namespace IB.Api.Client
{
    public class RestApiClient
    {
        private string _baseUri;
        private string _userAgent;

        public RestApiClient(string baseUri, string useragent)
        {
            _baseUri = baseUri;
            _userAgent = useragent;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
        }
        private T GetApiResponse<T>(string query)
        {
            using (var httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    httpClient.DefaultRequestHeaders.Add("User-Agent", _userAgent);
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var url = $"{_baseUri}/{query}";
                    var result = httpClient.GetStringAsync(new Uri(url)).Result;
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
        }
        private T PostApiResponse<T>(string query)
        {
            using (var httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    httpClient.DefaultRequestHeaders.Add("User-Agent", _userAgent);
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var url = $"{_baseUri}/{query}";
                    using var stringContent = new StringContent("");
                    var response = httpClient.PostAsync(new Uri($"{_baseUri}/{query}"), stringContent).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
        }

        public SessionValidateResponse SessionValidate()
        {
            return GetApiResponse<SessionValidateResponse>("portal/sso/validate");
        }
        public SessionStatusResponse SessionStatus()
        {
            return GetApiResponse<SessionStatusResponse>("portal/iserver/auth/status");
        }
        public SessionReauthenticateResponse SessionReauthenticate()
        {
            return PostApiResponse<SessionReauthenticateResponse>("portal/iserver/reauthenticate");
        }
        public SessionTickleResponse SessionTickle()
        {
            return GetApiResponse<SessionTickleResponse>("portal/tickle");
        }
        public AccountBrokerageResponse BrokerageAccounts()
        {
            return GetApiResponse<AccountBrokerageResponse>("portal/portfolio/accounts");
        }
    }
}