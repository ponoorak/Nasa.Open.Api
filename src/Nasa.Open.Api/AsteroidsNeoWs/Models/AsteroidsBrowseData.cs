namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsBrowseData
    {
        [JsonProperty("links")]
        public AsteroidsFeedLinks Links { get; set; }

        [JsonProperty("page")]
        public AsteroidsBrowsePage Page { get; set; }

        [JsonProperty("near_earth_objects")]
        public AsteroidsFeedNeo[] NearEarthObjects { get; set; }
    }
}