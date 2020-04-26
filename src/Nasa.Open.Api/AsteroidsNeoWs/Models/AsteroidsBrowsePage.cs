namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsBrowsePage
    {
        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("total_elements")]
        public int? TotalElements { get; set; }

        [JsonProperty("total_pages")]
        public int? TotalPages { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }
    }
}
