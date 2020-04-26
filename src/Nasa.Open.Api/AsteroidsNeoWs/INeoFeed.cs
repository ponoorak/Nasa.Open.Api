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
        Task<AsteroidsFeedData> GetAsync(DateTime startDate, DateTime endDate);
    }
}