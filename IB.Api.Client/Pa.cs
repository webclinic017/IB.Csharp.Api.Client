namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Pa
    {
        [JsonProperty("post")]
        public FyiNotificationsMoreGet Post { get; set; }
    }
}
