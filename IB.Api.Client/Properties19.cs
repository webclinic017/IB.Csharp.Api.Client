namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties19
    {
        [JsonProperty("A")]
        public AlertMessage A { get; set; }

        [JsonProperty("FC")]
        public AlertMessage Fc { get; set; }

        [JsonProperty("H")]
        public AlertMessage H { get; set; }

        [JsonProperty("FD")]
        public AlertMessage Fd { get; set; }

        [JsonProperty("FN")]
        public AlertMessage Fn { get; set; }
    }
}
