namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverMarketdataUnsubscribeall
    {
        [JsonProperty("get")]
        public IserverMarketdataUnsubscribeallGet Get { get; set; }
    }
}
