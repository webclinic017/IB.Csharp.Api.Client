namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleShort
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public IndecentProperties Properties { get; set; }
    }
}
