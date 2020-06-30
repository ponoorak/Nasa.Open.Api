namespace Nasa.Open.Api.TLE
{
    using System.Threading.Tasks;
    using Attributes;
    using Earth.Models;
    using Extensions;
    using Models;

    /// <summary>
    /// The TLE API provides up to date two line element set records, the data is updated daily from CelesTrak and served in JSON format
    /// </summary>
    public interface ITle
    {
        //enum TleSort
        //{
            
        //}
        Task<TleResult> GetAsync(string query = "");
    }


    [EndPoint(Consts.BASE_TLE, "api/tle")]
    internal class Tle : Connection, ITle
    {
        public async Task<TleResult> GetAsync(string query = "")
        {
            var message = new MessageArgs();

            if (!string.IsNullOrWhiteSpace(query))
            {
                message.Add("search", query);
            }

            var result = await Request<TleResult>(message);
            return result;
        }

        public Tle(NasaOpenApiState state) : base("", state)
        {
        }
    }
}
