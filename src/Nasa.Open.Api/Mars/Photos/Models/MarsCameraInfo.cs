namespace Nasa.Open.Api.Mars.Photos.Models
{
    using Newtonsoft.Json;

    public class MarsCameraInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }
}