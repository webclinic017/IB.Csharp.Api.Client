namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HistoryData
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public HistoryDataProperties Properties { get; set; }
    }
}
