namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class LocationTreeProperties
    {
        [JsonProperty("Location")]
        public Location Location { get; set; }
    }
}
