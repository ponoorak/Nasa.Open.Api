namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Browse the overall Asteroid data-set
    /// </summary>
    public interface INeoBrowse
    {
        /// <summary>
        /// Browse the overall Asteroid data-set
        /// </summary>
        /// <returns>AsteroidsBrowseData</returns>
        /// <see cref="AsteroidsBrowseData"/>
        Task<AsteroidsBrowseData> GetAsync();
    }
}