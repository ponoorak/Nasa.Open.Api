namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using System;
    using Newtonsoft.Json;

    public struct AsteroidsFeedNeo
    {
        [JsonProperty("links")]
        public AsteroidsFeedLinks Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("neo_reference_id")]
        public string NeoReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public Uri NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitudeH { get; set; }

        [JsonProperty("estimated_diameter")]
        public AsteroidsFeedDiameter EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public AsteroidsFeedCloseApproachData[] CloseApproachData { get; set; }

        [JsonProperty("orbital_data")]
        public AsteroidsFeedOrbitalData OrbitalData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }
}
