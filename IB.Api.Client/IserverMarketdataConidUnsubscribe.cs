namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverMarketdataConidUnsubscribe
    {
        [JsonProperty("get")]
        public IserverMarketdataConidUnsubscribeGet Get { get; set; }
    }
}
