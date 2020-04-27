namespace Nasa.Open.Api
{
    using System;
    using APOD;
    using AsteroidsNeoWs;
    using Configuration;
    using Earth;
    using Mars.Photos;
    using Mars.Weather;

    internal class NasaOpenApiState
    {
        public int Remaining { get; internal set; }
        public int Limit { get; internal set; }
    }

    public class NasaOpenApi
    {
        /// <summary>
        /// Get Remaining calls available (depend from api key)
        /// </summary>
        public int Remaining => _nasaOpenApiState.Remaining;

        /// <summary>
        /// Get Limit calls tu use (depend from api key)
        /// http://api.nasa.gov
        /// </summary>
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
                throw new ArgumentException("Provided api_key is invalid, genere new key using https://api.nasa.gov/");
            }

            Apod = new Apod(apiKey, _nasaOpenApiState);
            NeoFeed = new NeoFeed(apiKey, _nasaOpenApiState);
            NeoLookup = new NeoLookup(apiKey, _nasaOpenApiState);
            NeoToday = new NeoToday(apiKey, _nasaOpenApiState);
            NeoSentry = new NeoSentry(apiKey, _nasaOpenApiState);
            NeoBrowse = new NeoBrowse(apiKey, _nasaOpenApiState);
            NeoStats = new NeoStats(apiKey, _nasaOpenApiState);
            MarsPhotos = new MarsPhotos(apiKey, _nasaOpenApiState);
            EarthImage = new EarthImage(apiKey, _nasaOpenApiState);
            EarthAssets = new EarthAssets(apiKey, _nasaOpenApiState);
            //MarsWeather = new MarsWeather(apiKey, _nasaOpenApiState);
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
        public IApod Apod { get; }

        /// <summary>
        /// Retrieve a list of Asteroids based on their closest approach date to Earth
        /// </summary>
        /// <see cref="INeoFeed"/>
        public INeoFeed NeoFeed { get; }

        /// <summary>
        /// Lookup a specific Asteroid based on its NASA JPL small body (SPK-ID) 
        /// </summary>
        /// <see cref="INeoLookup"/>
        public INeoLookup NeoLookup { get; }

        /// <summary>
        /// Near Earth Objects Today
        /// </summary>
        ///<see cref="INeoToday"/>
        public INeoToday NeoToday { get; }

        /// <summary>
        /// Nasa Earth Impact Monitoring
        /// </summary>
        /// <see cref="INeoSentry"/>
        public INeoSentry NeoSentry { get; }

        /// <summary>
        /// Browse the overall Asteroid data-set
        /// </summary>
        /// <see cref="INeoBrowse"/>
        public INeoBrowse NeoBrowse { get; }

        public INeoStats NeoStats { get; }

        /// <summary>
        /// This API is designed to collect image data gathered by NASA's Curiosity, Opportunity, and Spirit rovers on Mars
        /// </summary>
        /// <see cref="IMarsPhotos"/>
        public IMarsPhotos MarsPhotos { get; }

        ///// <summary>
        ///// This API provides per-Sol summary data for each of the last seven available Sols
        ///// </summary>
        ///// <see cref="MarsWeather"/>
        //public IMarsWeather MarsWeather { get; }

        /// <summary>
        /// This endpoint retrieves the Landsat 8 image for the supplied location and date. 
        /// </summary>
        /// <see cref="IEarthImage"/>
        public IEarthImage EarthImage { get; }

        /// <summary>
        /// this endpoint retrieves the date-times and asset names for closest available imagery for a supplied location and date.
        /// </summary>
        public IEarthAssets EarthAssets { get; }
    }
}
