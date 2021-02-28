namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema5
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public CunningItems Items { get; set; }
    }
}
