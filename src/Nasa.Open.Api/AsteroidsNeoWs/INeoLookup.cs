namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Lookup a specific Asteroid based on its NASA JPL small body (SPK-ID) 
    /// </summary>
    public interface INeoLookup
    {
        /// <summary>
        /// Details neo asteroid
        /// </summary>
        /// <param name="asteroidId">Asteroid SPK-ID correlates to the NASA JPL small body</param>
        /// <returns>AsteroidsFeedNeo</returns>
        /// <see cref="AsteroidsFeedNeo"/>
        /// <see cref="AsteroidsFeedNeo.Id"/>
        Task<AsteroidsFeedNeo> GetAsync(int asteroidId);
    }
}