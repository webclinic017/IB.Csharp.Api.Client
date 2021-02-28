namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ConExchMap
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public AccountAlias Items { get; set; }
    }
}
