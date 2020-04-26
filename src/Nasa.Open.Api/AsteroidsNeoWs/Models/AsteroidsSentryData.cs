namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsSentryData
    {
        [JsonProperty("links")]
        public AsteroidsFeedLinks Links { get; set; }

        [JsonProperty("page")]
        public AsteroidsBrowsePage Page { get; set; }

        [JsonProperty("sentry_objects")]
        public AsteroidsSentryObject[] SentryObjects { get; set; }
    }
}