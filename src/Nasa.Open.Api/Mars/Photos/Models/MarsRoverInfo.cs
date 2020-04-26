namespace Nasa.Open.Api.Mars.Photos.Models
{
    using System;
    using Newtonsoft.Json;

    public class MarsRoverInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("landing_date")]
        public DateTime? LandingDate { get; set; }

        [JsonProperty("launch_date")]
        public DateTime? LaunchDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("max_sol")]
        public int MaxSol { get; set; }

        [JsonProperty("max_date")]
        public DateTime? MaxDate { get; set; }

        [JsonProperty("total_photos")]
        public int TotalPhotos { get; set; }

        [JsonProperty("cameras")]
        public MarsCameraInfo[] Cameras { get; set; }
    }
}