namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverSecdefStrikes
    {
        [JsonProperty("get")]
        public IserverSecdefStrikesGet Get { get; set; }
    }
}
