namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ContractsProperties
    {
        [JsonProperty("Contract")]
        public ContractClass Contract { get; set; }
    }
}
