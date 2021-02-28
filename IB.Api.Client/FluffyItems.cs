namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public FluffyProperties Properties { get; set; }
    }
}
