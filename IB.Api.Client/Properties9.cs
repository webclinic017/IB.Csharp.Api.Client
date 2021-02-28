namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties9
    {
        [JsonProperty("chg")]
        public AccountAlias Chg { get; set; }

        [JsonProperty("hasAccounts")]
        public AccountAlias HasAccounts { get; set; }

        [JsonProperty("accountTypeName")]
        public AccountAlias AccountTypeName { get; set; }

        [JsonProperty("rtn")]
        public AccountAlias Rtn { get; set; }

        [JsonProperty("endVal")]
        public AccountAlias EndVal { get; set; }

        [JsonProperty("accountTypeCode")]
        public AccountAlias AccountTypeCode { get; set; }

        [JsonProperty("startVal")]
        public AccountAlias StartVal { get; set; }
    }
}
