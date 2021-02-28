namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class DateProperties
    {
        [JsonProperty("start")]
        public AlertMessage Start { get; set; }

        [JsonProperty("end")]
        public AlertMessage End { get; set; }
    }
}
