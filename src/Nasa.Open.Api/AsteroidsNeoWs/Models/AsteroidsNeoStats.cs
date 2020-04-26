namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using System;
    using Newtonsoft.Json;

    public struct AsteroidsNeoStats
    {
        [JsonProperty("near_earth_object_count")]
        public long NeoCount { get; set; }

        [JsonProperty("close_approach_count")]
        public long CloseApproachCount { get; set; }

        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }
    }
}