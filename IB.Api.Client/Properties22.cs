namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties22
    {
        [JsonProperty("canTrade")]
        public AccountAlias CanTrade { get; set; }

        [JsonProperty("canSign")]
        public AccountAlias CanSign { get; set; }

        [JsonProperty("type")]
        public AccountAlias Type { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("identDocs")]
        public IdentDocs IdentDocs { get; set; }
    }
}
