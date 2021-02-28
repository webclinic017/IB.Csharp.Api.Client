namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StringItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties39 Properties { get; set; }
    }
}
