namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScannerResult
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public ScannerResultProperties Properties { get; set; }
    }
}
