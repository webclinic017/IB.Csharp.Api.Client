namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ContractClass
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public ContractItems Items { get; set; }
    }
}
