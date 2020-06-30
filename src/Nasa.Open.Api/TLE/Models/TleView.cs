namespace Nasa.Open.Api.TLE.Models
{
    using System;
    using Newtonsoft.Json;

    public class TleView
    {
        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("first")]
        public Uri First { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("last")]
        public Uri Last { get; set; }
    }
}
