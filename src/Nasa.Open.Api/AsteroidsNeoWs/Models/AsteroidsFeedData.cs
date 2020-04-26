namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AsteroidsFeedData
    {
        [JsonProperty("links")]
        public AsteroidsFeedLinks Links { get; set; }

        [JsonProperty("element_count")]
        public int? ElementCount { get; set; }

        [JsonProperty("near_earth_objects")]
        public Dictionary<string, List<AsteroidsFeedNeo>> NearEarthObjects { get; set; }
    }
}
