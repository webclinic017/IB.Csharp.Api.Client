namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema8
    {
        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAliasType? Type { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public SystemErrorProperties Properties { get; set; }
    }
}
