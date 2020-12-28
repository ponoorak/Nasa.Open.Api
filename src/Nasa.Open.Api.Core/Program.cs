using System;

namespace Nasa.Open.Api.Core
{
    using Earth;
    using Mars.Photos;

    class Program
    {
        private const string ApiKey = "4b4KsGIf2cO59woV3PH0ER4fxJd5vjfh1SbBtwtp";

        static void Main(string[] args)
        {
            var nasaOpenApi = new NasaOpenApi(ApiKey);
            var tle = nasaOpenApi.Tle.GetAsync().Result;
            var apodService = nasaOpenApi.Apod.GetAsync().Result;
            var statsService = nasaOpenApi.NeoStats.GetAsync().Result;
            var marsPhotos = nasaOpenApi.MarsPhotos.GetAsync(1000, CameraName.FHAZ).Result;
            var earthImage = nasaOpenApi.EarthImage.GetAsync(29.78, -95.33, DateTime.Parse("2018-01-01")).Result;
            var earthAssets = nasaOpenApi.EarthAssets.GetAsync(29.78, -95.33, DateTime.Parse("2018-01-01")).Result;

            Console.WriteLine(@"Results from Mars.Open.Api");
            Console.WriteLine($@"Result APOD Url = {apodService.Url}");
            Console.WriteLine($@"Result NEO COUNT = {statsService.NeoCount}");
            Console.WriteLine($@"Result Mars Length = {marsPhotos.Photos.Length}");
            Console.WriteLine($@"Result Earth DataLength = {earthImage.Length}");
            Console.WriteLine($@"Result Earth Assets = {earthAssets.Resource.Dataset}");
            Console.WriteLine($@"Result TLE Count = {tle.Member.Length}"); 
            Console.WriteLine($@"Api Remaining Calls = {nasaOpenApi.Remaining}");
            Console.WriteLine($@"Api Limit Calls = {nasaOpenApi.Limit}");
        }
    }
}
