namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties46
    {
        [JsonProperty("display_name")]
        public AccountAlias DisplayName { get; set; }

        [JsonProperty("type")]
        public AccountAlias Type { get; set; }

        [JsonProperty("filters")]
        public Included Filters { get; set; }
    }
}
