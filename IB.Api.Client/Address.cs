namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Address
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public AddressProperties Properties { get; set; }
    }
}
