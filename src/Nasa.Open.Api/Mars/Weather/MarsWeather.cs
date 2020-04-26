namespace Nasa.Open.Api.Mars.Weather
{
    using System.Threading.Tasks;
    using Attributes;
    using Models;

    /// <summary>
    /// This API provides per-Sol summary data for each of the last seven available Sols
    /// </summary>
    public interface IMarsWeather
    {
        Task<MarsWeatherData> GetAsync();
    }

    [EndPoint(Consts.BASE_URL1, "insight_weather")]
    internal class MarsWeather : Base, IMarsWeather
    {
        public MarsWeather(string apiKey, NasaOpenApiState state) : base(apiKey, state)
        {
        }

        public async Task<MarsWeatherData> GetAsync()
        {
            var result = await Request<MarsWeatherData>(new MessageArgs
            {
                { "version", "1.0" },
                { "feedtype", "json" }
            });
            return result;
        }
    }
}
