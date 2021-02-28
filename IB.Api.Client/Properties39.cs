namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties39
    {
        [JsonProperty("ORTH")]
        public AlertMessage Orth { get; set; }

        [JsonProperty("SP")]
        public AlertMessage Sp { get; set; }

        [JsonProperty("LP")]
        public AlertMessage Lp { get; set; }

        [JsonProperty("PC")]
        public AlertMessage Pc { get; set; }

        [JsonProperty("TA")]
        public AlertMessage Ta { get; set; }

        [JsonProperty("TU")]
        public AlertMessage Tu { get; set; }

        [JsonProperty("ROA")]
        public AlertMessage Roa { get; set; }

        [JsonProperty("ROP")]
        public AlertMessage Rop { get; set; }

        [JsonProperty("TT")]
        public AlertMessage Tt { get; set; }

        [JsonProperty("UNP")]
        public AlertMessage Unp { get; set; }
    }
}
