namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class LocationItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties4 Properties { get; set; }
    }
}
