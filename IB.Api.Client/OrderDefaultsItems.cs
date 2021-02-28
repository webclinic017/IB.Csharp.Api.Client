namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class OrderDefaultsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties38 Properties { get; set; }
    }
}
