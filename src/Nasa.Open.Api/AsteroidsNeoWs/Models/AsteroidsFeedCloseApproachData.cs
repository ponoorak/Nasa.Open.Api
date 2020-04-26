namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using System;
    using Newtonsoft.Json;

    public class AsteroidsFeedCloseApproachData
    {
        [JsonProperty("close_approach_date")]
        public DateTime? CloseApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public long EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public AsteroidsFeedApproachRelativeVelocity RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public AsteroidsFeedMissDistance MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }
}