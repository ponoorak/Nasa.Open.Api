namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsFeedDiameterValues
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }
}