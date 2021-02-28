namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverSecdefSearch
    {
        [JsonProperty("post")]
        public IserverSecdefSearchPost Post { get; set; }
    }
}
