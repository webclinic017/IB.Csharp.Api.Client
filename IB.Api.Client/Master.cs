namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Master
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public MasterProperties Properties { get; set; }
    }
}
