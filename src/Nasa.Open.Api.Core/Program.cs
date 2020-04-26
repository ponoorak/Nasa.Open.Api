using System;

namespace Nasa.Open.Api.Core
{
    using Mars.Photos;

    class Program
    {
        
        private const string ApiKey = "DEMO_KEY";

        static void Main(string[] args)
        {
            var nasaOpenApi = new NasaOpenApi(ApiKey);

            var apodService = nasaOpenApi.Apod.GetAsync().Result;
            var statsService = nasaOpenApi.NeoStats.GetAsync().Result;
            var marsPhotos = nasaOpenApi.MarsPhotos.GetAsync(1000, CameraName.FHAZ).Result;
            
            Console.WriteLine("Results from Mars.Open.Api");
            Console.WriteLine($"Result APOD Url = {apodService.Url}");
            Console.WriteLine($"Result NEO COUNT = {statsService.NeoCount}");
            Console.WriteLine($"Result Mars Length = {marsPhotos.Photos.Length}");
            Console.WriteLine($"Api Remaining Calls = {nasaOpenApi.Remaining}");
            Console.WriteLine($"Api Limit Calls = {nasaOpenApi.Limit}");
        }
    }
}
