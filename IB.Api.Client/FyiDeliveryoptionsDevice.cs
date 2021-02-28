namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiDeliveryoptionsDevice
    {
        [JsonProperty("post")]
        public PutClass Post { get; set; }
    }
}
