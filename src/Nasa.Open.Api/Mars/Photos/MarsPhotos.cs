namespace Nasa.Open.Api.Mars.Photos
{
    using System;
    using System.Threading.Tasks;
    using Attributes;
    using Extensions;
    using Models;

    [EndPoint(Consts.BASE_URL1, "mars-photos/api/v1/rovers/curiosity/photos")]
    internal class MarsPhotos : Connection, IMarsPhotos
    {
        public MarsPhotos(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        private async Task<MarsData> GetAsync(DateTime? earthDate = null, CameraName? camera = null, int? sol = null, int page = 1)
        {

            var messageArgs = new MessageArgs { { "page", page } };

            if (earthDate != null)
            {
                messageArgs.Add("earth_date", earthDate.Value.ToDefault());
            }

            if (camera != null)
            {
                messageArgs.Add("camera", camera);
            }

            if (sol != null)
            {
                messageArgs.Add("sol", sol);
            }

            var result = await Request<MarsData>(messageArgs);
            return result;
        }

        public Task<MarsData> GetAsync(DateTime earthDate, CameraName? camera = null, int page = 1)
        {
            return GetAsync(earthDate, camera, null, page);
        }

        public Task<MarsData> GetAsync(int sol, CameraName? camera = null, int page = 1)
        {
            return GetAsync(null, camera, sol, page);
        }
    }
}
