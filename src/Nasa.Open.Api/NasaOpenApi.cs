namespace Nasa.Open.Api
{
    using System;
    using APOD;
    using AsteroidsNeoWs;
    using Configuration;
    using Mars.Photos;
    using Mars.Weather;

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

        private readonly NasaOpenApiState _nasaOpenApiState = new NasaOpenApiState();
        /// <summary>
        /// Initialize using api_key
        /// </summary>
        /// <param name="apiKey"></param>
        public NasaOpenApi(string apiKey)
        {
            //8 = DEMO_KEY
            if (string.IsNullOrWhiteSpace(apiKey) || apiKey.Length < 8)
            {
                throw new ArithmeticException("Provided api_key is invalid, genere new key using https://api.nasa.gov/");
            }

            _apiKey = apiKey;
        }

        /// <summary>
        /// Initialize using config
        /// </summary>
        /// <param name="config"></param>
        public NasaOpenApi(NasaOpenApiConfiguration config) : this(config.ApiKey)
        { 
        }

        /// <summary>
        /// Interface for APOD https://apod.nasa.gov/apod/astropix.html
        /// </summary>
        /// <see cref="IApod"/>
        public IApod Apod => new Apod(_apiKey, _nasaOpenApiState);

        /// <summary>
        /// Retrieve a list of Asteroids based on their closest approach date to Earth
        /// </summary>
        /// <see cref="INeoFeed"/>
        public INeoFeed NeoFeed => new NeoFeed(_apiKey, _nasaOpenApiState);

        /// <summary>
        /// Lookup a specific Asteroid based on its NASA JPL small body (SPK-ID) 
        /// </summary>
        /// <see cref="INeoLookup"/>
        public INeoLookup NeoLookup => new NeoLookup(_apiKey, _nasaOpenApiState);

        /// <summary>
        /// Near Earth Objects Today
        /// </summary>
        ///<see cref="INeoToday"/>
        public INeoToday NeoToday => new NeoToday(_apiKey, _nasaOpenApiState);

        /// <summary>
        /// Nasa Earth Impact Monitoring
        /// </summary>
        /// <see cref="INeoSentry"/>
        public INeoSentry NeoSentry => new NeoSentry(_apiKey, _nasaOpenApiState);

        /// <summary>
        /// Browse the overall Asteroid data-set
        /// </summary>
        /// <see cref="INeoBrowse"/>
        public INeoBrowse NeoBrowse => new NeoBrowse(_apiKey, _nasaOpenApiState);

        public INeoStats NeoStats => new NeoStats(_apiKey, _nasaOpenApiState);

        /// <summary>
        /// This API is designed to collect image data gathered by NASA's Curiosity, Opportunity, and Spirit rovers on Mars
        /// </summary>
        public IMarsPhotos MarsPhotos => new MarsPhotos(_apiKey, _nasaOpenApiState);

        /// <summary>
        /// This API provides per-Sol summary data for each of the last seven available Sols
        /// </summary>
        //public IMarsWeather MarsWeather => new MarsWeather(_apiKey, _nasaOpenApiState);
    }
}
