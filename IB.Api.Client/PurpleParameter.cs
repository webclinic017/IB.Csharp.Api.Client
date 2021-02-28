namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("in")]
        public In In { get; set; }

        [JsonProperty("required")]
        public bool ParameterRequired { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAliasType? Type { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public IndigoSchema Schema { get; set; }
    }
}
