namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ExpireTime
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }
    }
}
