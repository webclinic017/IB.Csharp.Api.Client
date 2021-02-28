namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HilariousProperties
    {
        [JsonProperty("Others")]
        public AccountAlias Others { get; set; }

        [JsonProperty("Utilities")]
        public AccountAlias Utilities { get; set; }

        [JsonProperty("Energy")]
        public AccountAlias Energy { get; set; }

        [JsonProperty("Technology")]
        public AccountAlias Technology { get; set; }

        [JsonProperty("Financial")]
        public AccountAlias Financial { get; set; }

        [JsonProperty("Communications")]
        public AccountAlias Communications { get; set; }
    }
}
