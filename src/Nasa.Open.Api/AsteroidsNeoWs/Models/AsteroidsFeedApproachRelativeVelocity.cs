namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsFeedApproachRelativeVelocity
    {
        [JsonProperty("kilometers_per_second")]
        public string KilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public string KilometersPerHour { get; set; }

        [JsonProperty("miles_per_hour")]
        public string MilesPerHour { get; set; }
    }
}