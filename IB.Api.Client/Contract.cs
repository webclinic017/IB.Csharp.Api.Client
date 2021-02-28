namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Contract
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public ContractProperties Properties { get; set; }
    }
}
