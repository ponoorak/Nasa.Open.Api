using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System.Threading.Tasks;
    using Attributes;
    using Extensions;
    using Models;

    [EndPoint(Consts.BASE_URL1, "neo/rest/v1/feed")]
    internal class NeoFeed : Base, INeoFeed
    {
        public NeoFeed(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<AsteroidsFeedData> GetAsync(DateTime startDate, DateTime endDate)
        {
            var messageArgs = new MessageArgs { { "start_date", startDate.ToDefault() }, { "end_date", endDate.ToDefault() } };

            var result = await Request<AsteroidsFeedData>(messageArgs);
            return result;
        }
    }
}
