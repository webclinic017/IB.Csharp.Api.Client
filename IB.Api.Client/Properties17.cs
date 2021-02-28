namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties17
    {
        [JsonProperty("DT")]
        public AlertMessage Dt { get; set; }

        [JsonProperty("FC")]
        public AlertMessage Fc { get; set; }
    }
}
