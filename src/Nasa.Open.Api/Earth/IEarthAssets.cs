namespace Nasa.Open.Api.Earth
{
    using System;
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// his endpoint retrieves the date-times and asset names for closest available imagery for a supplied location and date.
    /// </summary>
    public interface IEarthAssets
    {
        Task<EarthAssetsData> GetAsync(double latitude, double longitude, DateTime? date = null, double sizeInDegrees = 0.25, bool cloudScore = false);
    }
}