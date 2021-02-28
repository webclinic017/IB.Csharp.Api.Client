namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties49
    {
        [JsonProperty("display_name")]
        public AccountAlias DisplayName { get; set; }

        [JsonProperty("code")]
        public AccountAlias Code { get; set; }

        [JsonProperty("instruments")]
        public Included Instruments { get; set; }
    }
}
