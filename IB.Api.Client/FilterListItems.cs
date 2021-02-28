namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FilterListItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties45 Properties { get; set; }
    }
}
