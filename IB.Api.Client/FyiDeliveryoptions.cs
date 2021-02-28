namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiDeliveryoptions
    {
        [JsonProperty("get")]
        public FyiDeliveryoptionsGet Get { get; set; }
    }
}
