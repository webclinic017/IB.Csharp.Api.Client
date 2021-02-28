namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AmbitiousItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties29 Properties { get; set; }
    }
}
