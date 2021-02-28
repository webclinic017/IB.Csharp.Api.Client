namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HistoryResult
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public HistoryResultProperties Properties { get; set; }
    }
}
