using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.Open.Api.APOD
{
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for APOD https://apod.nasa.gov/apod/astropix.html
    /// </summary>
    public interface IApod
    {
        /// <summary>
        /// Return Astronomy Picture Of a Day
        /// </summary>
        /// <param name="date">The date of the APOD image to retrieve</param>
        /// <param name="highDefinition">Retrieve the URL for the high resolution image</param>
        /// <returns>ApodModel</returns>
        /// <see cref="ApodModel"/>
        Task<ApodModel> GetAsync(DateTime? date = null, bool highDefinition = false);
    }
}
