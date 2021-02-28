namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverAccountTrades
    {
        [JsonProperty("get")]
        public IserverAccountTradesGet Get { get; set; }
    }
}
