namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AddressProperties
    {
        [JsonProperty("street")]
        public AccountAlias Street { get; set; }

        [JsonProperty("street2")]
        public AccountAlias Street2 { get; set; }

        [JsonProperty("city")]
        public AccountAlias City { get; set; }

        [JsonProperty("state")]
        public AccountAlias State { get; set; }

        [JsonProperty("postalCode")]
        public AccountAlias PostalCode { get; set; }

        [JsonProperty("country")]
        public AccountAlias Country { get; set; }

        [JsonProperty("countryCode")]
        public AccountAlias CountryCode { get; set; }

        [JsonProperty("compact")]
        public AccountAlias Compact { get; set; }
    }
}
