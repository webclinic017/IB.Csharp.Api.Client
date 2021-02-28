namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties6
    {
        [JsonProperty("inScanTime")]
        public AccountAlias InScanTime { get; set; }

        [JsonProperty("distance")]
        public AccountAlias Distance { get; set; }

        [JsonProperty("contractID")]
        public AccountAlias ContractId { get; set; }
    }
}
