namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Tickle
    {
        [JsonProperty("post")]
        public TicklePost Post { get; set; }
    }
}
