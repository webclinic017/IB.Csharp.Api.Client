namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ContractItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties6 Properties { get; set; }
    }
}
