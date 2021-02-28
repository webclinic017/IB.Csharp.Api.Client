namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties11
    {
        [JsonProperty("acctid")]
        public AccountAlias Acctid { get; set; }

        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("cur")]
        public AlertMessage Cur { get; set; }

        [JsonProperty("fxRate")]
        public AlertMessage FxRate { get; set; }

        [JsonProperty("desc")]
        public AlertMessage Desc { get; set; }

        [JsonProperty("date")]
        public AlertMessage Date { get; set; }

        [JsonProperty("type")]
        public AlertMessage Type { get; set; }

        [JsonProperty("qty")]
        public AlertMessage Qty { get; set; }

        [JsonProperty("pr")]
        public AlertMessage Pr { get; set; }

        [JsonProperty("amt")]
        public AlertMessage Amt { get; set; }
    }
}
