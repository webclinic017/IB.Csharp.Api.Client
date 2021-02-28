namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyProperties
    {
        [JsonProperty("condition_type")]
        public AlertMessage ConditionType { get; set; }

        [JsonProperty("conidex")]
        public ExpireTime Conidex { get; set; }

        [JsonProperty("contract_description_1")]
        public AssetClass ContractDescription1 { get; set; }

        [JsonProperty("condition_operator")]
        public ExpireTime ConditionOperator { get; set; }

        [JsonProperty("condition_trigger_method")]
        public ExpireTime ConditionTriggerMethod { get; set; }

        [JsonProperty("condition_value")]
        public ExpireTime ConditionValue { get; set; }

        [JsonProperty("condition_logic_bind")]
        public AlertMessage ConditionLogicBind { get; set; }

        [JsonProperty("condition_time_zone")]
        public AlertMessage ConditionTimeZone { get; set; }
    }
}
