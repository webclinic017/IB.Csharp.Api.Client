namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Futures
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public FuturesItems Items { get; set; }
    }
}
