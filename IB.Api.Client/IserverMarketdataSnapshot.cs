namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverMarketdataSnapshot
    {
        [JsonProperty("get")]
        public IserverMarketdataSnapshotGet Get { get; set; }
    }
}
