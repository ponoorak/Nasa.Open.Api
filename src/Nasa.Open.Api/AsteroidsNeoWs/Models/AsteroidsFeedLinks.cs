namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsFeedLinks
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Previous { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
