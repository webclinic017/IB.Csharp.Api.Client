namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyConditions
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public FluffyItems Items { get; set; }
    }
}
