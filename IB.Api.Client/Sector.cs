namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Sector
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public SectorProperties Properties { get; set; }
    }
}
