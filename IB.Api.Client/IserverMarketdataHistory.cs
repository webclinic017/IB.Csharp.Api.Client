namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverMarketdataHistory
    {
        [JsonProperty("get")]
        public IserverMarketdataHistoryGet Get { get; set; }
    }
}
