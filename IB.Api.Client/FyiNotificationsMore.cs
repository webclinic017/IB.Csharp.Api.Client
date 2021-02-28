namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiNotificationsMore
    {
        [JsonProperty("get")]
        public FyiNotificationsMoreGet Get { get; set; }
    }
}
