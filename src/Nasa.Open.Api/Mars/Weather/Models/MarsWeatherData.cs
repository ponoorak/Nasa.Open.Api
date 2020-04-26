namespace Nasa.Open.Api.Mars.Weather.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MarsWeatherData
    {
        [JsonProperty("sol_keys")]
        public long[] SolKeys { get; set; }

        [JsonProperty("validity_checks")]
        public dynamic ValidityChecks { get; set; }
    }
}
