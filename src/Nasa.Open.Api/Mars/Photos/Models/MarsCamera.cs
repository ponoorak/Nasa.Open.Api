namespace Nasa.Open.Api.Mars.Photos.Models
{
    using Newtonsoft.Json;

    public class MarsCamera
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rover_id")]
        public int RoverId { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }
}