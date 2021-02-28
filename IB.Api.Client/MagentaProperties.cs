namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MagentaProperties
    {
        [JsonProperty("symbol")]
        public AccountAlias Symbol { get; set; }

        [JsonProperty("conid")]
        public AlertMessage Conid { get; set; }

        [JsonProperty("underlyingConid")]
        public AccountAlias UnderlyingConid { get; set; }

        [JsonProperty("expirationDate")]
        public AccountAlias ExpirationDate { get; set; }

        [JsonProperty("ltd")]
        public AlertMessage Ltd { get; set; }
    }
}
