namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class RulesProperties
    {
        [JsonProperty("orderTypes")]
        public Included OrderTypes { get; set; }

        [JsonProperty("orderTypesOutside")]
        public Included OrderTypesOutside { get; set; }

        [JsonProperty("defaultSize")]
        public AlertMessage DefaultSize { get; set; }

        [JsonProperty("sizeIncrement")]
        public AccountAlias SizeIncrement { get; set; }

        [JsonProperty("tifTypes")]
        public Included TifTypes { get; set; }

        [JsonProperty("limitPrice")]
        public AlertMessage LimitPrice { get; set; }

        [JsonProperty("stopprice")]
        public AlertMessage Stopprice { get; set; }

        [JsonProperty("preview")]
        public AlertMessage Preview { get; set; }

        [JsonProperty("displaySize")]
        public AccountAlias DisplaySize { get; set; }

        [JsonProperty("increment")]
        public AccountAlias Increment { get; set; }
    }
}
