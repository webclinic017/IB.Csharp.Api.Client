namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AllocationItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public TentacledProperties Properties { get; set; }
    }
}
