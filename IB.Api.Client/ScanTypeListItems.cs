namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScanTypeListItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties49 Properties { get; set; }
    }
}
