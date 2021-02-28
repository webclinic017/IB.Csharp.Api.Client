namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class BalanceByDateProperties
    {
        [JsonProperty("series")]
        public Series Series { get; set; }
    }
}
