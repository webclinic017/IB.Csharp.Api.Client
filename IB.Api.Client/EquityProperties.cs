namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class EquityProperties
    {
        [JsonProperty("current")]
        public AccountAlias Current { get; set; }

        [JsonProperty("change")]
        public AccountAlias Change { get; set; }

        [JsonProperty("after")]
        public AccountAlias After { get; set; }
    }
}
