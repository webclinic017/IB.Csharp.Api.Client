namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Total
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public TotalProperties Properties { get; set; }
    }
}
