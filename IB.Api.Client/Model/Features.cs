using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public partial class Features
    {
        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("wlms")]
        public bool Wlms { get; set; }

        [JsonProperty("realtime")]
        public bool Realtime { get; set; }

        [JsonProperty("bond")]
        public bool Bond { get; set; }

        [JsonProperty("optionChains")]
        public bool OptionChains { get; set; }

        [JsonProperty("calendar")]
        public bool Calendar { get; set; }

        [JsonProperty("newMf")]
        public bool NewMf { get; set; }
    }
}