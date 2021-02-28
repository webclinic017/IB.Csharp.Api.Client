namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiDeliveryoptionsDeviceId
    {
        [JsonProperty("delete")]
        public FyiDeliveryoptionsDeviceIdDelete Delete { get; set; }
    }
}
