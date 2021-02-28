namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SsoValidate
    {
        [JsonProperty("get")]
        public SsoValidateGet Get { get; set; }
    }
}
