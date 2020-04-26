namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Browse the overall Asteroid data-set
    /// </summary>
    public interface INeoBrowse
    {
        Task<AsteroidsBrowseData> GetAsync(int page, int size);
    }
}