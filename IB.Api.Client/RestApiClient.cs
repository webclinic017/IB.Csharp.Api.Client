using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using IB.Api.Client.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        private T GetApiResponse<T>(string query, bool printResult)
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
                    PrintResult(printResult, result);
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
        }
        private void PrintResult(bool printResult, string result)
        {
            if (printResult)
                Console.WriteLine(result);
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
            return GetApiResponse<SessionValidateResponse>("portal/sso/validate", false);
        }
        public SessionStatusResponse SessionStatus()
        {
            return GetApiResponse<SessionStatusResponse>("portal/iserver/auth/status", false);
        }
        public SessionReauthenticateResponse SessionReauthenticate()
        {
            return PostApiResponse<SessionReauthenticateResponse>("portal/iserver/reauthenticate");
        }
        public SessionTickleResponse SessionTickle()
        {
            return GetApiResponse<SessionTickleResponse>("portal/tickle", false);
        }
        public PortfolioAccountsResponse PortfolioAccounts()
        {
            return GetApiResponse<PortfolioAccountsResponse>("portal/portfolio/accounts", false);
        }
        public PortfolioSubAccountsResponse PortfolioSubAccounts()
        {
            return GetApiResponse<PortfolioSubAccountsResponse>("portal/portfolio/subaccounts", false);
        }
        public PortfolioAccountSummaryResponse PortfolioAccountSummary(string accountId)
        {
            JObject data = GetApiResponse<JObject>($"portal/portfolio/{accountId}/summary", false);
            return new PortfolioAccountSummaryResponse(data);
        }
        public PortfolioPositionsResponse PortfolioPositions(string accountId)
        {
            return GetApiResponse<PortfolioPositionsResponse>($"portal/portfolio/{accountId}/positions/0", false);
        }
        public PortfolioAccountLedgerResponse PortfolioAccountLedger(string accountId)
        {
            return GetApiResponse<PortfolioAccountLedgerResponse>($"portal/portfolio/{accountId}/ledger", false);
        }
        public TradesResponse Trades()
        {
            return GetApiResponse<TradesResponse>("portal/iserver/account/trades", false);
        }
    }
}