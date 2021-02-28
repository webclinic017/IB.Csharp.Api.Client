namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class EntitiesItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties22 Properties { get; set; }
    }
}
