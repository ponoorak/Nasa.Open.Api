namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System;
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Retrieve a list of Asteroids based on their closest approach date to Earth
    /// https://api.nasa.gov/
    /// </summary>
    public interface INeoFeed
    {
        /// <summary>
        /// Retrieve data
        /// </summary>
        /// <param name="startDate">Starting date for asteroid search</param>
        /// <param name="endDate">Ending date for asteroid search</param>
        /// <returns>AsteroidsFeedData</returns>
        /// <see cref="AsteroidsFeedData"/>
        Task<AsteroidsFeedData> GetAsync(DateTime startDate, DateTime endDate);
    }
}