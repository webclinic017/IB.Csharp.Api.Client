namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TrsrvSecdefSchedule
    {
        [JsonProperty("get")]
        public TrsrvSecdefScheduleGet Get { get; set; }
    }
}
