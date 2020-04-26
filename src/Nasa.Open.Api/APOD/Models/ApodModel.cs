namespace Nasa.Open.Api.APOD
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Response for APOD request
    /// </summary>
    public class ApodModel
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        [JsonProperty("hdurl")]
        public Uri HighQualityUrl { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("service_version")]
        public string ServiceVersion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
