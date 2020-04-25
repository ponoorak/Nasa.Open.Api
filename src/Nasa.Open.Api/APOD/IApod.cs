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
        /// Retrieve APOD async
        /// </summary>
        /// <returns></returns>
        Task<ApodModel> GetAsync(DateTime? date = null, bool highDefinition = false);
    }
}
