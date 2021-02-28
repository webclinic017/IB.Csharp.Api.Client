namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties7
    {
        [JsonProperty("name")]
        public AlertMessage Name { get; set; }

        [JsonProperty("chineseName")]
        public AlertMessage ChineseName { get; set; }

        [JsonProperty("assetClass")]
        public AssetClass AssetClass { get; set; }

        [JsonProperty("contracts")]
        public ContractsClass Contracts { get; set; }
    }
}
