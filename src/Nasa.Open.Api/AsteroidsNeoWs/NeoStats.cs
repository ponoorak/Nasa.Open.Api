using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Attributes;
    using Models;

    public interface INeoStats
    {
        Task<AsteroidsNeoStats> GetAsync();
    }

    [EndPoint(Consts.BASE_URL1, "neo/rest/v1/stats")]
    internal class NeoStats : Connection, INeoStats
    {
        public NeoStats(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<AsteroidsNeoStats> GetAsync()
        {
            var result = await Request<AsteroidsNeoStats>();
            return result;
        }
    }
}
