namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Entities
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public EntitiesItems Items { get; set; }
    }
}
