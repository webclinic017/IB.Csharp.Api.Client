namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleDate
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public DateProperties Properties { get; set; }
    }
}
