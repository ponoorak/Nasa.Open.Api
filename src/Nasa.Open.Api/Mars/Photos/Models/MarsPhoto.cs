namespace Nasa.Open.Api.Mars.Photos.Models
{
    using System;
    using Newtonsoft.Json;

    public class MarsPhoto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sol")]
        public int Sol { get; set; }

        [JsonProperty("camera")]
        public MarsCamera Camera { get; set; }

        [JsonProperty("img_src")]
        public string ImageSource { get; set; }

        [JsonProperty("earth_date")]
        public DateTime? EarthDate { get; set; }

        [JsonProperty("rover")]
        public MarsRoverInfo RoverInfo { get; set; }
    }
}