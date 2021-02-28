namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SeriesItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties10 Properties { get; set; }
    }
}
