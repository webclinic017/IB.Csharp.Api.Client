namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties14
    {
        [JsonProperty("NM")]
        public AlertMessage Nm { get; set; }

        [JsonProperty("I")]
        public AlertMessage I { get; set; }

        [JsonProperty("UI")]
        public AlertMessage Ui { get; set; }

        [JsonProperty("A")]
        public AlertMessage A { get; set; }
    }
}
