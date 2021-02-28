namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiNotifications
    {
        [JsonProperty("get")]
        public FyiNotificationsGet Get { get; set; }
    }
}
