namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class EItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public Properties14 Properties { get; set; }
    }
}
