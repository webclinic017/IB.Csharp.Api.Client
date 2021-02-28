namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema16
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties53 Properties { get; set; }
    }
}
