namespace Nasa.Open.Api.Earth
{
    using System;
    using System.Threading.Tasks;
    using Attributes;
    using Extensions;
    using Models;

    [EndPoint(Consts.BASE_URL1, "planetary/earth/assets")]
    internal class EarthAssets : Base, IEarthAssets
    {
        public async Task<EarthAssetsData> GetAsync(double latitude, double longitude, DateTime? date = null, double sizeInDegrees = 0.25, bool cloudScore = false)
        {
            var message = new MessageArgs
            {
                {"lat", latitude},
                {"lon", longitude},
                {"dim", sizeInDegrees},
                {"cloud_score", cloudScore }
            };

            if (date != null)
            {
                message.Add("date", date.Value.ToDefault());
            }

            var result = await Request<EarthAssetsData>(message);
            return result;
        }

        public EarthAssets(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }
    }
}
