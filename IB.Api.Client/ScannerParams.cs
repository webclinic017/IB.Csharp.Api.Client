namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScannerParams
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public ScannerParamsProperties Properties { get; set; }
    }
}
