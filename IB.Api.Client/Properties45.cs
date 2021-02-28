namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties45
    {
        [JsonProperty("group")]
        public AccountAlias Group { get; set; }

        [JsonProperty("display_name")]
        public AccountAlias DisplayName { get; set; }

        [JsonProperty("code")]
        public AccountAlias Code { get; set; }

        [JsonProperty("type")]
        public AccountAlias Type { get; set; }
    }
}
