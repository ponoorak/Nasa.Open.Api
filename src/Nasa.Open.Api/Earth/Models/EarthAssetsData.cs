namespace Nasa.Open.Api.Earth.Models
{
    using System;
    using Newtonsoft.Json;

    public class EarthAssetsData
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public EarthAssetsResource Resource { get; set; }

        [JsonProperty("service_version")]
        public string ServiceVersion { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
