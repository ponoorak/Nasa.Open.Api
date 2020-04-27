namespace Nasa.Open.Api.AsteroidsNeoWs
{
    using System;
    using System.Threading.Tasks;
    using Attributes;
    using Extensions;
    using Models;

    [EndPoint(Consts.BASE_URL1, "neo/rest/v1/feed")]
    internal class NeoFeed : Connection, INeoFeed
    {
        public NeoFeed(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<AsteroidsFeedData> GetAsync(DateTime startDate, DateTime? endDate = null)
        {
            var messageArgs = new MessageArgs { { "start_date", startDate.ToDefault() } };
            if (endDate != null)
            {
                messageArgs.Add("end_date", endDate.Value.ToDefault());
            }

            var result = await Request<AsteroidsFeedData>(messageArgs);
            return result;
        }
    }
}
