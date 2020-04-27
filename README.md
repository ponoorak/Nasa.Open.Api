# Nasa.Open.Api
Unofficial .NET Wrapper for { NASA APIs } (https://api.nasa.gov)

Underdevelopment, now support: 
* APOD
* NEO
* MarsPhotos
* EarthPhotos
* EarthAssets
	
# Ussage

``` C#
class Program
{
    private const string ApiKey = "DEMO_KEY";
    static void Main(string[] args)
    {
	    var api = new NasaOpenApi(ApiKey);
            var apodService = api.Apod.GetAsync().Result;
            var statsService = api.NeoStats.GetAsync().Result;
            var marsPhotos = api.MarsPhotos.GetAsync(1000, CameraName.FHAZ).Result;
			var earthImage = nasaOpenApi.EarthImage.GetAsync(54.372158, 8.638306).Result;
            var earthAssets = nasaOpenApi.EarthAssets.GetAsync(54.372158, 8.638306).Result;

			Console.WriteLine("Results from Mars.Open.Api");
            Console.WriteLine($"Result APOD Url = {apodService.Url}");
            Console.WriteLine($"Result NEO COUNT = {statsService.NeoCount}");
            Console.WriteLine($"Result Mars Length = {marsPhotos.Photos.Length}");
			Console.WriteLine($"Result Earth DataLength = {earthImage.Length}");
            Console.WriteLine($"Result Earth Assets = {earthAssets.Resource.Dataset}");
            Console.WriteLine($"Api Remaining Calls = {api.Remaining}");
	    Console.WriteLine($"Api Limit Calls = {api.Limit}");
	}
}
```


## License
[MIT](https://choosealicense.com/licenses/mit/)
