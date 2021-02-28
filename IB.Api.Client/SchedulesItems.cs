namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SchedulesItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties59 Properties { get; set; }
    }
}
