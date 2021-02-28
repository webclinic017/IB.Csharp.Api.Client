namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Performance
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public PerformanceProperties Properties { get; set; }
    }
}
