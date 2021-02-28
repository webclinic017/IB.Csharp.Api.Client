using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Contracts.Request
{
    public class ContractSearchRequest
    {
        [JsonProperty("symbol")]
        public string Symbol;

        [JsonProperty("name")]
        public bool IsName;

        [JsonProperty("secType")]
        public string SecType;
    }
}