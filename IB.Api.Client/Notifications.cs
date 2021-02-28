namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Notifications
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public NotificationsItems Items { get; set; }
    }
}
