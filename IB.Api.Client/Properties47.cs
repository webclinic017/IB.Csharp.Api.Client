namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties47
    {
        [JsonProperty("display_name")]
        public AccountAlias DisplayName { get; set; }

        [JsonProperty("type")]
        public AccountAlias Type { get; set; }

        [JsonProperty("locations")]
        public Locations Locations { get; set; }
    }
}
