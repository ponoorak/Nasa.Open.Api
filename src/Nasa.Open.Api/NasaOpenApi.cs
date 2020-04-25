namespace Nasa.Open.Api
{
    using APOD;
    using Configuration;

    internal class NasaOpenApiState
    {
        public int Remaining { get; internal set; }
        public int Limit { get; internal set; }
    }

    public class NasaOpenApi
    {
        private readonly string _apiKey;

        public int Remaining => _nasaOpenApiState.Remaining;
        public int Limit => _nasaOpenApiState.Limit;

        private NasaOpenApiState _nasaOpenApiState = new NasaOpenApiState();
        /// <summary>
        /// Initialize using api_key
        /// </summary>
        /// <param name="apiKey"></param>
        public NasaOpenApi(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Initialize using config
        /// </summary>
        /// <param name="config"></param>
        public NasaOpenApi(NasaOpenApiConfiguration config) : this(config.ApiKey)
        { 
        }

        public IApod Apod => new Apod(_apiKey, _nasaOpenApiState);
    }
}
