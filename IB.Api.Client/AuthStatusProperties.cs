namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AuthStatusProperties
    {
        [JsonProperty("authenticated")]
        public AlertMessage Authenticated { get; set; }

        [JsonProperty("connected")]
        public AlertMessage Connected { get; set; }

        [JsonProperty("competing")]
        public AlertMessage Competing { get; set; }

        [JsonProperty("fail")]
        public AlertMessage Fail { get; set; }

        [JsonProperty("message")]
        public AlertMessage Message { get; set; }

        [JsonProperty("prompts")]
        public Prompts Prompts { get; set; }
    }
}
