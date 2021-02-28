namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PaSummary
    {
        [JsonProperty("post")]
        public FyiNotificationsGet Post { get; set; }
    }
}
