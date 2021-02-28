namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StickyProperties
    {
        [JsonProperty("STK")]
        public AccountAlias Stk { get; set; }

        [JsonProperty("OPT")]
        public AccountAlias Opt { get; set; }

        [JsonProperty("FUT")]
        public AccountAlias Fut { get; set; }

        [JsonProperty("WAR")]
        public AccountAlias War { get; set; }

        [JsonProperty("BOND")]
        public AccountAlias Bond { get; set; }

        [JsonProperty("CASH")]
        public AccountAlias Cash { get; set; }
    }
}
