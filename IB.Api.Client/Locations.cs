namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Locations
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public LocationsItems Items { get; set; }
    }
}
