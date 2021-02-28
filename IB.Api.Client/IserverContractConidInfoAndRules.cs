namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverContractConidInfoAndRules
    {
        [JsonProperty("get")]
        public IserverContractConidInfoAndRulesGet Get { get; set; }
    }
}
