namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class InstrumentListItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties46 Properties { get; set; }
    }
}
