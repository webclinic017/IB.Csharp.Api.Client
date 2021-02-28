namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties57
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public ItemsValue Symbol { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias Error { get; set; }
    }
}
