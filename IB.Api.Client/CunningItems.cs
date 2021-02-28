namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CunningItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties33 Properties { get; set; }
    }
}
