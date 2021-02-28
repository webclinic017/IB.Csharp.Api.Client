namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndigoProperties
    {
        [JsonProperty("Computers")]
        public AccountAlias Computers { get; set; }

        [JsonProperty("Semiconductors")]
        public AccountAlias Semiconductors { get; set; }

        [JsonProperty("Others")]
        public AccountAlias Others { get; set; }

        [JsonProperty("Chemicals")]
        public AccountAlias Chemicals { get; set; }

        [JsonProperty("Apparel")]
        public AccountAlias Apparel { get; set; }

        [JsonProperty("Communications")]
        public AccountAlias Communications { get; set; }
    }
}
