namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyData
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public StickyItems Items { get; set; }
    }
}
