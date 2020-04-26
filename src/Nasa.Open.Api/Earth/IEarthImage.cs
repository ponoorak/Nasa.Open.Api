namespace Nasa.Open.Api.Earth
{
    using System;
    using System.Threading.Tasks;

    public interface IEarthImage
    {
        Task<byte[]> GetAsync(double latitude, double longitude, DateTime? date = null, double sizeInDegrees = 0.25, bool cloudScore = false);
    }
}