using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.Open.Api.Mars.Weather.Models
{
    using Newtonsoft.Json;

    public class MarsWeatherSol
    {
        //[JsonProperty("AT")]
        //public object At { get; set; }

        //[JsonProperty("First_UTC")]
        //public DateTime? FirstUtc { get; set; }

        //[JsonProperty("HWS")]
        //public object Hws { get; set; }

        [JsonProperty("Last_UTC")]
        public DateTime? LastUtc { get; set; }

        //[JsonProperty("PRE")]
        //public object Pre { get; set; }

        //[JsonProperty("Season")]
        //public string Season { get; set; }

        //[JsonProperty("WD")]
        //public object Wd { get; set; }
    }
}
