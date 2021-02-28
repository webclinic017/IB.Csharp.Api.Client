namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Iserver
    {
        [JsonProperty("post")]
        public IserverAuthStatusPost Post { get; set; }
    }
}
