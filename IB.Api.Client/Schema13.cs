namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema13
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public FriskyItems Items { get; set; }
    }
}
