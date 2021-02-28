namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class NameProperties
    {
        [JsonProperty("salutation")]
        public AccountAlias Salutation { get; set; }

        [JsonProperty("firstName")]
        public AccountAlias FirstName { get; set; }

        [JsonProperty("lastName")]
        public AccountAlias LastName { get; set; }
    }
}
