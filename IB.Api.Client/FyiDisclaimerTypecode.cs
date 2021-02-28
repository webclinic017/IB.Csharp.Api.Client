namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiDisclaimerTypecode
    {
        [JsonProperty("get")]
        public FyiDisclaimerTypecodeGet Get { get; set; }

        [JsonProperty("put")]
        public PutClass Put { get; set; }
    }
}
