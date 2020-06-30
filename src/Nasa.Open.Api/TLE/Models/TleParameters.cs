namespace Nasa.Open.Api.TLE.Models
{
    using Newtonsoft.Json;

    public class TleParameters
    {
        public class Parameters
        {
            [JsonProperty("search")]
            public string Search { get; set; }

            [JsonProperty("sort")]
            public string Sort { get; set; }

            [JsonProperty("sort-dir")]
            public string SortDir { get; set; }

            [JsonProperty("page")]
            public long Page { get; set; }

            [JsonProperty("page-size")]
            public long PageSize { get; set; }
        }
    }
}
