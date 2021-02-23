using Newtonsoft.Json;

namespace IB.Api.Client.Request
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
