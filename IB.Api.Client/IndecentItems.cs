namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndecentItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties21 Properties { get; set; }
    }
}
