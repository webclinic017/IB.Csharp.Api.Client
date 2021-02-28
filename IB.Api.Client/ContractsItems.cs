namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ContractsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties8 Properties { get; set; }
    }
}
