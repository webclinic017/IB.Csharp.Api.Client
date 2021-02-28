namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Allocation
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public AllocationItems Items { get; set; }
    }
}
