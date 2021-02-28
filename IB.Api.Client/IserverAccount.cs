namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverAccount
    {
        [JsonProperty("post")]
        public IserverAccountPost Post { get; set; }
    }
}
