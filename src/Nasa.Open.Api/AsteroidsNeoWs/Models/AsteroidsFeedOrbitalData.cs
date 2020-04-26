namespace Nasa.Open.Api.AsteroidsNeoWs.Models
{
    using System;
    using Newtonsoft.Json;

    public class AsteroidsFeedOrbitalData
    {
        [JsonProperty("orbit_id")]
        public string OrbitId { get; set; }

        [JsonProperty("orbit_determination_date")]
        public DateTime? OrbitDeterminationDate { get; set; }

        [JsonProperty("first_observation_date")]
        public DateTime? FirstObservationDate { get; set; }

        [JsonProperty("last_observation_date")]
        public DateTime? LastObservationDate { get; set; }

        [JsonProperty("data_arc_in_days")]
        public UInt32? DataArcInDays { get; set; }

        [JsonProperty("observations_used")]
        public UInt32? ObservationsUsed { get; set; }

        [JsonProperty("orbit_uncertainty")]
        public string OrbitUncertainty { get; set; }

        [JsonProperty("minimum_orbit_intersection")]
        public string MinimumOrbitIntersection { get; set; }

        [JsonProperty("jupiter_tisserand_invariant")]
        public string JupiterTisserandInvariant { get; set; }

        [JsonProperty("epoch_osculation")]
        public string EpochOsculation { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("semi_major_axis")]
        public string SemiMajorAxis { get; set; }

        [JsonProperty("inclination")]
        public string Inclination { get; set; }

        [JsonProperty("ascending_node_longitude")]
        public string AscendingNodeLongitude { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("perihelion_distance")]
        public string PerihelionDistance { get; set; }

        [JsonProperty("perihelion_argument")]
        public string PerihelionArgument { get; set; }

        [JsonProperty("aphelion_distance")]
        public string AphelionDistance { get; set; }

        [JsonProperty("perihelion_time")]
        public string PerihelionTime { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("equinox")]
        public string Equinox { get; set; }

        [JsonProperty("orbit_class")]
        public AsteroidsFeedOrbitClass OrbitClass { get; set; }
    }
}