namespace Nasa.Open.Api.Configuration
{
    /// <summary>
    /// Configuration model for Api.
    /// It can be used as parameter or setting in config
    /// </summary>
    public class NasaOpenApiConfiguration
    {
        /// <summary>
        /// API ApiKey. You Can setup APi Key on https://api.nasa.gov/
        /// </summary>
        public string ApiKey { get; set; }
    }
}
