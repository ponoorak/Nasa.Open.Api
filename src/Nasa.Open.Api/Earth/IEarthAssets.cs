namespace Nasa.Open.Api.Earth
{
    using System;
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// this endpoint retrieves the date-times and asset names for closest available imagery for a supplied location and date.
    /// </summary>
    public interface IEarthAssets
    {
        /// <summary>
        /// Detailed information about image available
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="date">beginning of 30 day date range that will be used to look for closest image to that date</param>
        /// <param name="sizeInDegrees">width and height of image in degrees</param>
        /// <returns><c>EarthAssetsData</c></returns>
        /// <see cref="EarthAssetsData"/>
        Task<EarthAssetsData> GetAsync(double latitude, double longitude, DateTime? date = null, double sizeInDegrees = 0.25);
    }
}