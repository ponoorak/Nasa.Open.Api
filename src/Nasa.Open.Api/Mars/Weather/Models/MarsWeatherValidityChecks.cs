namespace Nasa.Open.Api.Mars.Weather.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MarsWeatherValidityChecks : Dictionary<string, object>
    {
        [JsonProperty("sol_hours_required")]
        public long SolHoursRequired { get; set; }

        [JsonProperty("sols_checked")]
        public long[] SolsChecked { get; set; }
    }
}
