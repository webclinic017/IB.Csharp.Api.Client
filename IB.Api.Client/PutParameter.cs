namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PutParameter
    {
        [JsonProperty("in")]
        public In In { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ParameterRequired { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public FluffySchema Schema { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAliasType? Type { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Default { get; set; }
    }
}
