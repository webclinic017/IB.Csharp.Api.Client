namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties3
    {
        [JsonProperty("type")]
        public AlertMessage Type { get; set; }

        [JsonProperty("name")]
        public AlertMessage Name { get; set; }

        [JsonProperty("shortName")]
        public AccountAlias ShortName { get; set; }

        [JsonProperty("secType")]
        public AlertMessage SecType { get; set; }

        [JsonProperty("filters")]
        public AlertMessage Filters { get; set; }
    }
}
