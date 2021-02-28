namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties24
    {
        [JsonProperty("set")]
        public AccountAlias Set { get; set; }

        [JsonProperty("acctId")]
        public AccountAlias AcctId { get; set; }
    }
}
