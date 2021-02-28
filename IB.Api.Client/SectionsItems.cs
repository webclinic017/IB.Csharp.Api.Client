namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SectionsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties52 Properties { get; set; }
    }
}
