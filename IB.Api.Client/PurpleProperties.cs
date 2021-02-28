namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleProperties
    {
        [JsonProperty("type")]
        public AlertMessage Type { get; set; }

        [JsonProperty("conidex")]
        public ExpireTime Conidex { get; set; }

        [JsonProperty("operator")]
        public ExpireTime Operator { get; set; }

        [JsonProperty("triggerMethod")]
        public ExpireTime TriggerMethod { get; set; }

        [JsonProperty("value")]
        public ExpireTime Value { get; set; }

        [JsonProperty("logicBind")]
        public AlertMessage LogicBind { get; set; }

        [JsonProperty("timeZone")]
        public AlertMessage TimeZone { get; set; }
    }
}
