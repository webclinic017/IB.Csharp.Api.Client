using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using IB.Api.Client.Helper;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint
{
    public class BaseEndpoint
    {
        private const string _baseUri = "https://localhost:5000/v1/portal";
        private const string _userAgent = "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:85.0) Gecko/20100101 Firefox/85.0";
        public event EventHandler<ApiResponse> OnApiResponse;
        private void OnApiResponseHandler(ApiResponse apiResponse)
        {
            OnApiResponse?.Invoke(this, apiResponse);
        }

        protected BaseEndpoint()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
        }
        protected T GetApiResponse<T>(string query)
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

                    var url = $"{_baseUri}{query}";
                    var result = httpClient.GetStringAsync(new Uri(url)).Result;
                    OnApiResponseHandler(new ApiResponse { Query = query, Result = result });
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
        }
        protected T PostApiResponse<T>(string query, string payload = "")
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

                    var url = $"{_baseUri}{query}";
                    using var stringContent = new StringContent(payload);
                    var response = httpClient.PostAsync(new Uri($"{_baseUri}/{query}"), stringContent).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    OnApiResponseHandler(new ApiResponse { Query = query, Result = result });
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
        }
        protected T DeleteApiResponse<T>(string query)
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

                    var url = $"{_baseUri}{query}";
                    var response = httpClient.DeleteAsync(new Uri($"{_baseUri}/{query}")).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    OnApiResponseHandler(new ApiResponse { Query = query, Result = result });
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
        }
    }
}
