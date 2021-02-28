namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Name
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public NameProperties Properties { get; set; }
    }
}
