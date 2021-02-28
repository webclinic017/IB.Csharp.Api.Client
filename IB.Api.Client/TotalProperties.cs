namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TotalProperties
    {
        [JsonProperty("chg")]
        public AlertMessage Chg { get; set; }

        [JsonProperty("rtn")]
        public AlertMessage Rtn { get; set; }

        [JsonProperty("incompleteData")]
        public AlertMessage IncompleteData { get; set; }

        [JsonProperty("endVal")]
        public AccountAlias EndVal { get; set; }

        [JsonProperty("startVal")]
        public AccountAlias StartVal { get; set; }
    }
}
