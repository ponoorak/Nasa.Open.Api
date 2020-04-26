namespace Nasa.Open.Api.Mars.Photos.Models
{
    using Newtonsoft.Json;

    public class MarsData
    {
        [JsonProperty("photos")]
        public MarsPhoto[] Photos;
    }
}
