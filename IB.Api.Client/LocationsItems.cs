namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class LocationsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties48 Properties { get; set; }
    }
}
