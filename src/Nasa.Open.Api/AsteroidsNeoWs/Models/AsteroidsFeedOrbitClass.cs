namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsFeedOrbitClass
    {
        [JsonProperty("orbit_class_type")]
        public string OrbitClassType { get; set; }

        [JsonProperty("orbit_class_description")]
        public string OrbitClassDescription { get; set; }

        [JsonProperty("orbit_class_range")]
        public string OrbitClassRange { get; set; }
    }
}