using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Attributes;
    using Models;

    [EndPoint(Consts.BASE_URL1, "neo/rest/v1/neo/browse")]
    internal class NeoBrowse : Base, INeoBrowse
    {
        public NeoBrowse(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<AsteroidsBrowseData> GetAsync(int page, int size)
        {
            var result = await Request<AsteroidsBrowseData>();
            return result;
        }
    }
}
