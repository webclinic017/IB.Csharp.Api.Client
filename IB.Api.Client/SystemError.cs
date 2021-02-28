namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SystemError
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public SystemErrorProperties Properties { get; set; }
    }
}
