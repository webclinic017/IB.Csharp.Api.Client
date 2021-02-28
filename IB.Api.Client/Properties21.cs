namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties21
    {
        [JsonProperty("applicantId")]
        public AccountAlias ApplicantId { get; set; }

        [JsonProperty("entities")]
        public Entities Entities { get; set; }
    }
}
