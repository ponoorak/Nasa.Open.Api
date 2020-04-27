namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Attributes;
    using Models;

    [EndPoint(Consts.BASE_URL1, "neo/rest/v1/neo/sentry")]
    internal class NeoSentry : Connection, INeoSentry
    {
        public NeoSentry(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<AsteroidsSentryData> GetAsync(bool active = true, int page = 0, int size = 50)
        {
            var result = await Request<AsteroidsSentryData>(new MessageArgs
            {
                { "is_active", active.ToString() },
                { "page", page },
                { "size", size }
            });

            return result;
        }

        public async Task<AsteroidsSentryObject> GetAsync(int asteroidId)
        {
            var result = await Request<AsteroidsSentryObject>(null, asteroidId.ToString());
            return result;
        }
    }
}
