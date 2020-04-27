namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Neo Asteroids today
    /// </summary>
    public interface INeoToday
    {
        /// <summary>
        /// Get Data
        /// </summary>
        /// <returns>AsteroidsFeedData</returns>
        /// <see cref="AsteroidsFeedData"/>
        Task<AsteroidsFeedData> GetAsync();
    }
}