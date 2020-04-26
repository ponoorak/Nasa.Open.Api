namespace Nasa.Open.Api.Earth.Models
{
    using Newtonsoft.Json;

    public class EarthAssetsResource
    {
        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("planet")]
        public string Planet { get; set; }
    }
}
