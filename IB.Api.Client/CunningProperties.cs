namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CunningProperties
    {
        [JsonProperty("index_date_type")]
        public AccountAlias IndexDateType { get; set; }

        [JsonProperty("event_type")]
        public AccountAlias EventType { get; set; }

        [JsonProperty("data")]
        public AlertMessage Data { get; set; }

        [JsonProperty("conids")]
        public Included Conids { get; set; }

        [JsonProperty("index_date")]
        public AlertMessage IndexDate { get; set; }

        [JsonProperty("source")]
        public AlertMessage Source { get; set; }

        [JsonProperty("event_key")]
        public AlertMessage EventKey { get; set; }

        [JsonProperty("tooltips")]
        public AccountAlias Tooltips { get; set; }

        [JsonProperty("status")]
        public AccountAlias Status { get; set; }
    }
}
