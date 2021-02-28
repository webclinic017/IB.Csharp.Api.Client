namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScanTypeItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties5 Properties { get; set; }
    }
}
