namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties59
    {
        [JsonProperty("clearingCycleEndTime")]
        public AccountAlias ClearingCycleEndTime { get; set; }

        [JsonProperty("tradingScheduleDate")]
        public AlertMessage TradingScheduleDate { get; set; }

        [JsonProperty("sessions")]
        public Sessions Sessions { get; set; }

        [JsonProperty("tradingTimes")]
        public TradingTimes TradingTimes { get; set; }
    }
}
