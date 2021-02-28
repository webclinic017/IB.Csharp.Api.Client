namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Inds
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public IndsItems Items { get; set; }
    }
}
