namespace Nasa.Open.Api.Mars.Photos
{
    using System;
    using System.Threading.Tasks;
    using Attributes;
    using Extensions;
    using Models;

    public enum CameraName
    {
        FHAZ,       //Front Hazard Avoidance Camera
        RHAZ,       //Rear Hazard Avoidance Camera
        MAST,       //Mast Camera
        CHEMCAM,    //Chemistry and Camera Complex
        MAHLI,      //Mars Hand Lens Imager
        MARDI,      //Mars Descent Imager
        NAVCAM,     //Navigation Camera
        PANCAM,     //Panoramic Camera
        MINITES     //Miniature Thermal Emission Spectrometer (Mini-TES)
    }

    /// <summary>
    /// This API is designed to collect image data gathered by NASA's Curiosity, Opportunity, and Spirit rovers on Mars
    /// </summary>
    public interface IMarsPhotos
    {
        /// <summary>
        /// Querying by Earth date
        /// </summary>
        /// <param name="earthDate">corresponding date on earth for the given sol</param>
        /// <param name="camera"><see cref="CameraName"/></param>
        /// <param name="page">25 items per page returned</param>
        /// <returns><see cref="MarsData"/></returns>
        Task<MarsData> GetAsync(DateTime earthDate, CameraName? camera = null, int page = 1);

        /// <summary>
        /// Querying by Martian sol
        /// </summary>
        /// <param name="sol">sol (ranges from 0 to max found in endpoint)</param>
        /// <param name="camera"><see cref="CameraName"/></param>
        /// <param name="page">25 items per page returned</param>
        /// <returns><c>MarsData</c></returns>
        Task<MarsData> GetAsync(int sol, CameraName? camera = null, int page = 1);
    }

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
