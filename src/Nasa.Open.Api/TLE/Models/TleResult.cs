namespace Nasa.Open.Api.TLE.Models
{
    using System;
    using Newtonsoft.Json;

    public class TleResult
    {
        [JsonProperty("@context")]
        public Uri Context { get; set; }

        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("totalItems")]
        public long TotalItems { get; set; }

        [JsonProperty("member")]
        public TleMember[] Member { get; set; }

        [JsonProperty("parameters")]
        public TleParameters Parameters { get; set; }

        [JsonProperty("view")]
        public TleView View { get; set; }
    }
}
