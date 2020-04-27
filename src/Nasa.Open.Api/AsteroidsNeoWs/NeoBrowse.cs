namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Attributes;
    using Models;

    [EndPoint(Consts.BASE_URL1, "neo/rest/v1/neo/browse")]
    internal class NeoBrowse : Connection, INeoBrowse
    {
        public NeoBrowse(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<AsteroidsBrowseData> GetAsync()
        {
            var result = await Request<AsteroidsBrowseData>();
            return result;
        }
    }
}
