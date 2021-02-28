namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class InstrumentItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties3 Properties { get; set; }
    }
}
