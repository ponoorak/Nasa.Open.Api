namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Nasa Earth Impact Monitoring
    /// </summary>
    public interface INeoSentry
    {
        /// <summary>
        /// Get data about impact monitor
        /// </summary>
        /// <param name="active">is asteroid still active</param>
        /// <param name="page">page nr</param>
        /// <param name="size">items per page</param>
        /// <returns>AsteroidsSentryData</returns>
        /// <see cref="AsteroidsSentryData"/>
        /// <see cref="AsteroidsSentryObject"/>
        Task<AsteroidsSentryData> GetAsync(bool active = true, int page = 0, int size = 50);

        /// <summary>
        /// Detail information about asteroid
        /// </summary>
        /// <param name="asteroidId"></param>
        /// <returns>AsteroidsSentryObject</returns>
        /// <see cref="AsteroidsSentryObject"/>
        Task<AsteroidsSentryObject> GetAsync(int asteroidId);
    }
}