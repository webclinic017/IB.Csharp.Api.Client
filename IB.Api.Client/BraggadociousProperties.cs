namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class BraggadociousProperties
    {
        [JsonProperty("D")]
        public AlertMessage D { get; set; }

        [JsonProperty("ID")]
        public AlertMessage Id { get; set; }

        [JsonProperty("FC")]
        public AlertMessage Fc { get; set; }

        [JsonProperty("MD")]
        public AlertMessage Md { get; set; }

        [JsonProperty("MS")]
        public AlertMessage Ms { get; set; }

        [JsonProperty("R")]
        public AlertMessage R { get; set; }
    }
}
