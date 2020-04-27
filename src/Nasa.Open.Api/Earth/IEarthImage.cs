namespace Nasa.Open.Api.Earth
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// This endpoint retrieves the Landsat 8 image for the supplied location and date. 
    /// </summary>
    public interface IEarthImage
    {
        /// <summary>
        /// Note that the returned object may not match the supplied date exactly. Instead, the image closest to the supplied date is returned.
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="date">date of image; if not supplied, then the most recent image (i.e., closest to today) is returned</param>
        /// <param name="sizeInDegrees">width and height of image in degrees</param>
        /// <param name="cloudScore">calculate the percentage of the image covered by clouds [NOT CURRENTLY AVAILABLE!!!!]</param>
        /// <returns>Image data byte</returns>
        Task<byte[]> GetAsync(double latitude, double longitude, DateTime? date = null, double sizeInDegrees = 0.25, bool cloudScore = false);
    }
}