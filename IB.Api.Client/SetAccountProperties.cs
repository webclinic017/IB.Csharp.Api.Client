namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SetAccountProperties
    {
        [JsonProperty("acctId")]
        public AlertMessage AcctId { get; set; }
    }
}
