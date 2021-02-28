namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverAccountAccountIdOrderOrderId
    {
        [JsonProperty("post")]
        public IserverAccountAccountIdOrderOrderIdPost Post { get; set; }

        [JsonProperty("delete")]
        public IserverAccountAccountIdOrderOrderIdDelete Delete { get; set; }
    }
}
