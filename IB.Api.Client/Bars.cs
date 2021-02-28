namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Bars
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public BarsProperties Properties { get; set; }
    }
}
