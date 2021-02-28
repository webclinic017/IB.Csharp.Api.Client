namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class LocationTreeItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties47 Properties { get; set; }
    }
}
