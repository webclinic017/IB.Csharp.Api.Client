namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverAccounts
    {
        [JsonProperty("get")]
        public IserverAccountsGet Get { get; set; }
    }
}
