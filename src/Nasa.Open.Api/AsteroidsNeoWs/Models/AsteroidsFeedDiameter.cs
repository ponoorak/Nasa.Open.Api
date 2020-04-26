namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsFeedDiameter
    {
        [JsonProperty("kilometers")]
        public AsteroidsFeedDiameterValues Kilometers { get; set; }

        [JsonProperty("meters")]
        public AsteroidsFeedDiameterValues Meters { get; set; }

        [JsonProperty("miles")]
        public AsteroidsFeedDiameterValues Miles { get; set; }

        [JsonProperty("feet")]
        public AsteroidsFeedDiameterValues Feets { get; set; }
    }
}