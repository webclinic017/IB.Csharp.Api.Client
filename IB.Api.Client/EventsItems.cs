namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class EventsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public CunningProperties Properties { get; set; }
    }
}
