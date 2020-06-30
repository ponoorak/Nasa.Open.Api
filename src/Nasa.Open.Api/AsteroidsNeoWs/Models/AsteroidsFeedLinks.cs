namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using System;
    using Newtonsoft.Json;

    public class AsteroidsFeedLinks
    {
        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("prev")]
        public Uri Previous { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }
    }
}
