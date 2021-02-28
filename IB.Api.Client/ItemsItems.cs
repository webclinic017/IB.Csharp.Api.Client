namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ItemsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties23 Properties { get; set; }
    }
}
