using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using IB.Api.Client.Request;
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
        private T GetApiResponse<T>(string query, bool printResult = false)
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
        private T PostApiResponse<T>(string query, string payload = null, bool printResult = false)
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
                    using var stringContent = new StringContent(payload);
                    var response = httpClient.PostAsync(new Uri($"{_baseUri}/{query}"), stringContent).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
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
        public SessionValidateResponse SessionValidate()
        {
            return GetApiResponse<SessionValidateResponse>("/sso/validate");
        }
        public SessionStatusResponse SessionStatus()
        {
            return GetApiResponse<SessionStatusResponse>("/iserver/auth/status");
        }
        public SessionReauthenticateResponse SessionReauthenticate()
        {
            return PostApiResponse<SessionReauthenticateResponse>("/iserver/reauthenticate");
        }
        public SessionTickleResponse SessionTickle()
        {
            return GetApiResponse<SessionTickleResponse>("/tickle");
        }
        public PortfolioAccountsResponse PortfolioAccounts()
        {
            return GetApiResponse<PortfolioAccountsResponse>("/portfolio/accounts");
        }
        public PortfolioSubAccountsResponse PortfolioSubAccounts()
        {
            return GetApiResponse<PortfolioSubAccountsResponse>("/portfolio/subaccounts");
        }
        public PortfolioAccountSummaryResponse PortfolioAccountSummary(string accountId)
        {
            JObject data = GetApiResponse<JObject>($"/portfolio/{accountId}/summary");
            return new PortfolioAccountSummaryResponse(data);
        }
        public PortfolioPositionsResponse PortfolioPositions(string accountId)
        {
            return GetApiResponse<PortfolioPositionsResponse>($"/portfolio/{accountId}/positions/0");
        }
        public PortfolioAccountLedgerResponse PortfolioAccountLedger(string accountId)
        {
            return GetApiResponse<PortfolioAccountLedgerResponse>($"/portfolio/{accountId}/ledger");
        }
        public PortfolioAnalystTransactionHistoryResponse PortfolioAnalystTransactionHistory(List<string> accountIds, int days)
        {
            var request = new TransactionHistoryRequest
            {
                AccountIds = accountIds,
                Days = days,
                Currency = "GBP"
            };
            var payload = JsonConvert.SerializeObject(request);
            return PostApiResponse<PortfolioAnalystTransactionHistoryResponse>("/pa/transactions", payload, true);
        }
        public ContractSearchResponse ContractSearch(string searchText, bool isName)
        {
            var request = new ContractSearchRequest
            {
                Symbol = searchText,
                IsName = isName
            };
            var payload = JsonConvert.SerializeObject(request);
            return PostApiResponse<ContractSearchResponse>("/iserver/secdef/search", payload);
        }
        public TradesResponse Trades()
        {
            return GetApiResponse<TradesResponse>("/iserver/account/trades");
        }
    }
}