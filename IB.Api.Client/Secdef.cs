namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Secdef
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public SecdefItems Items { get; set; }
    }
}
