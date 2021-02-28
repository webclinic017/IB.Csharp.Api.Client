namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CalendarRequest
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public CalendarRequestProperties Properties { get; set; }
    }
}
