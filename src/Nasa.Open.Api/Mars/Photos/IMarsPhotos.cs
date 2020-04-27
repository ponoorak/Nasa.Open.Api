namespace Nasa.Open.Api.Mars.Photos
{
    using System;
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// This API is designed to collect image data gathered by NASA's Curiosity, Opportunity, and Spirit rovers on Mars
    /// </summary>
    public interface IMarsPhotos
    {
        /// <summary>
        /// Querying by Earth date
        /// </summary>
        /// <param name="earthDate">corresponding date on earth for the given sol</param>
        /// <param name="camera"><see cref="CameraName"/></param>
        /// <param name="page">25 items per page returned</param>
        /// <returns><see cref="MarsData"/></returns>
        Task<MarsData> GetAsync(DateTime earthDate, CameraName? camera = null, int page = 1);

        /// <summary>
        /// Querying by Martian sol
        /// </summary>
        /// <param name="sol">sol (ranges from 0 to max found in endpoint)</param>
        /// <param name="camera"><see cref="CameraName"/></param>
        /// <param name="page">25 items per page returned</param>
        /// <returns><c>MarsData</c></returns>
        Task<MarsData> GetAsync(int sol, CameraName? camera = null, int page = 1);
    }
}