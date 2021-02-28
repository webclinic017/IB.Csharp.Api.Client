namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IdentDocsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("items")]
        public ItemsItems Items { get; set; }
    }
}
