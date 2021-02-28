namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties32
    {
        [JsonProperty("order_id")]
        public AccountAlias OrderId { get; set; }

        [JsonProperty("msg")]
        public AccountAlias Msg { get; set; }

        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("account")]
        public AccountAlias Account { get; set; }
    }
}
