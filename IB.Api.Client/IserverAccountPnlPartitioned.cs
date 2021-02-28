namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverAccountPnlPartitioned
    {
        [JsonProperty("get")]
        public IserverAccountPnlPartitionedGet Get { get; set; }
    }
}
