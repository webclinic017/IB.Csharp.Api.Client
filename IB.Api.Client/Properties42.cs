namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties42
    {
        [JsonProperty("confirmed")]
        public AlertMessage Confirmed { get; set; }
    }
}
