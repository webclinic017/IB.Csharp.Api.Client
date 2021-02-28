namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class NotificationsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public BraggadociousProperties Properties { get; set; }
    }
}
