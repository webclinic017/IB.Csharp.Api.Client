namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties1
    {
        [JsonProperty("id")]
        public AccountAlias Id { get; set; }

        [JsonProperty("idType")]
        public AlertMessage IdType { get; set; }

        [JsonProperty("start")]
        public AlertMessage Start { get; set; }

        [JsonProperty("baseCurrency")]
        public AccountAlias BaseCurrency { get; set; }

        [JsonProperty("returns")]
        public Prompts Returns { get; set; }

        [JsonProperty("end")]
        public AlertMessage End { get; set; }
    }
}
