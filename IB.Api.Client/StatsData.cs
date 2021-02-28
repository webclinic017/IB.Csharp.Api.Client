namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StatsData
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public StatsDataProperties Properties { get; set; }
    }
}
