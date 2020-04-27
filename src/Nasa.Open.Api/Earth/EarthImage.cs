namespace Nasa.Open.Api.Earth
{
    using System;
    using System.Threading.Tasks;
    using Attributes;
    using Extensions;

    [EndPoint(Consts.BASE_URL1, "planetary/earth/imagery")]
    internal class EarthImage : Connection, IEarthImage
    {
        public async Task<byte[]> GetAsync(double latitude, double longitude, DateTime? date = null, double sizeInDegrees = 0.25, bool cloudScore = false)
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

            var result = await RequestBinary(message);
            return result;
        }

        public EarthImage(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }
    }
}
