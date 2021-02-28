namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class InstrumentListClass
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public InstrumentListItems Items { get; set; }
    }
}
