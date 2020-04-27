namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Attributes;
    using Models;

    [EndPoint(Consts.BASE_URL1, "neo/rest/v1/neo")]
    internal class NeoLookup : Connection, INeoLookup
    {
        public NeoLookup(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<AsteroidsFeedNeo> GetAsync(int asteroidId)
        {
            var result = await Request<AsteroidsFeedNeo>(null, asteroidId.ToString());
            return result;
        }
    }
}
