namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Nasa Earth Impact Monitoring
    /// </summary>
    public interface INeoSentry
    {
        Task<AsteroidsSentryData> GetAsync(bool active = true, int page = 0, int size = 50);
        Task<AsteroidsSentryObject> GetAsync(int asteroidId);
    }
}