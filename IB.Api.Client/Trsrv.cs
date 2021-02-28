namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Trsrv
    {
        [JsonProperty("get")]
        public TrsrvFuturesGet Get { get; set; }
    }
}
