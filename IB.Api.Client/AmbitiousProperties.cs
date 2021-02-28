namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AmbitiousProperties
    {
        [JsonProperty("Industrial")]
        public AccountAlias Industrial { get; set; }

        [JsonProperty("Consumer")]
        public AccountAlias Consumer { get; set; }

        [JsonProperty("Diversified")]
        public AccountAlias Diversified { get; set; }
    }
}
