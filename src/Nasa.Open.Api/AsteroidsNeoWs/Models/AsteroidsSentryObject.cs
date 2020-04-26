namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using Newtonsoft.Json;

    public class AsteroidsSentryObject
    {
        [JsonProperty("links")]
        public AsteroidsFeedLinks Links { get; set; }

        [JsonProperty("spkId")]
        public string SpkId { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("sentryId")]
        public string SentryId { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("year_range_min")]
        public string YearRangeMin { get; set; }

        [JsonProperty("year_range_max")]
        public string YearRangeMax { get; set; }

        [JsonProperty("potential_impacts")]
        public long PotentialImpacts { get; set; }

        [JsonProperty("impact_probability")]
        public double ImpactProbability { get; set; }

        [JsonProperty("v_infinity")]
        public double V_Infinity { get; set; }

        [JsonProperty("absolute_magnitude")]
        public double AbsoluteMagnitude { get; set; }

        [JsonProperty("estimated_diameter")]
        public double EstimatedDiameter { get; set; }

        [JsonProperty("palermo_scale_ave")]
        public double PalermoScaleAve { get; set; }

        [JsonProperty("Palermo_scale_max")]
        public double PalermoScaleMax { get; set; }

        [JsonProperty("torino_scale")]
        public string TorinoScale { get; set; }

        [JsonProperty("last_obs")]
        public string LastObs { get; set; }

        [JsonProperty("last_obs_jd")]
        public string LastObs_jd { get; set; }

        [JsonProperty("url_nasa_details")]
        public string UrlNasaDetails { get; set; }

        [JsonProperty("url_orbital_elements")]
        public string UrlOrbitalElements { get; set; }

        [JsonProperty("is_active_sentry_object")]
        public bool IsActiveSentryObject { get; set; }

        [JsonProperty("average_lunar_distance")]
        public double AverageLunarDistance { get; set; }
    }
}