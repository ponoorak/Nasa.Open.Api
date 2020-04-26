namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Lookup a specific Asteroid based on its NASA JPL small body (SPK-ID) 
    /// </summary>
    public interface INeoLookup
    {
        Task<AsteroidsFeedNeo> GetAsync(int asteroidId);
    }
}