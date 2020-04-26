namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Neo Asteroids today
    /// </summary>
    public interface INeoToday
    {
        Task<AsteroidsFeedData> GetAsync();
    }
}