namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Tentacled200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public AccountAlias Schema { get; set; }
    }
}
