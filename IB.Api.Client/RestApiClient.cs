using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
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
        private T DeleteApiResponse<T>(string query, bool printResult = false)
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
                    var response = httpClient.DeleteAsync(new Uri($"{_baseUri}/{query}")).Result;
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
    }
}