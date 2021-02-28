namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverSecdefInfo
    {
        [JsonProperty("get")]
        public IserverSecdefInfoGet Get { get; set; }
    }
}
