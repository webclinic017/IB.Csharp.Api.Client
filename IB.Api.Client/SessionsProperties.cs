namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SessionsProperties
    {
        [JsonProperty("openingTime")]
        public AccountAlias OpeningTime { get; set; }

        [JsonProperty("closingTime")]
        public AccountAlias ClosingTime { get; set; }

        [JsonProperty("prop")]
        public AlertMessage Prop { get; set; }
    }
}
