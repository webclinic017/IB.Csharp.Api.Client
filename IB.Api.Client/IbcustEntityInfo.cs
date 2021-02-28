namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IbcustEntityInfo
    {
        [JsonProperty("get")]
        public IbcustEntityInfoGet Get { get; set; }
    }
}
