namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Location
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public LocationItems Items { get; set; }
    }
}
