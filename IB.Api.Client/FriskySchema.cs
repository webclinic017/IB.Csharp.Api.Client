namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FriskySchema
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public HilariousItems Items { get; set; }
    }
}
