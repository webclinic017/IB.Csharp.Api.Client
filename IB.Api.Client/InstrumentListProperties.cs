namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class InstrumentListProperties
    {
        [JsonProperty("Instrument")]
        public Instrument Instrument { get; set; }
    }
}
