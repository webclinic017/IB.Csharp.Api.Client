namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties18
    {
        [JsonProperty("acctIds")]
        public Included AcctIds { get; set; }

        [JsonProperty("freq", NullValueHandling = NullValueHandling.Ignore)]
        public Freq Freq { get; set; }

        [JsonProperty("conids", NullValueHandling = NullValueHandling.Ignore)]
        public Included Conids { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public ExpireTime Currency { get; set; }

        [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
        public PriceFactor Days { get; set; }
    }
}
