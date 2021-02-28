namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HilariousItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties26 Properties { get; set; }
    }
}
