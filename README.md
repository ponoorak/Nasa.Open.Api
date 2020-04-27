# Nasa.Open.Api ![Release](https://github.com/ponoorak/Nasa.Open.Api/workflows/Release/badge.svg?branch=master) [![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg?)](https://github.com/ponoorak/Nasa.Open.Api/blob/master/LICENSE)

Unofficial .NET Wrapper for { NASA APIs } (https://api.nasa.gov)

Underdevelopment, now support: 
* APOD
* NEO
* MarsPhotos
* EarthPhotos
* EarthAssets

# Instalation

```
Install-Package Nasa.Open.Api -Version 0.1.0
```

# Ussage

``` C#
class Program
{
    private const string ApiKey = "DEMO_KEY";
    static void Main(string[] args)
    {
	var nasaOpenApi = new NasaOpenApi(ApiKey);

	var apodService = nasaOpenApi.Apod.GetAsync().Result;
	var statsService = nasaOpenApi.NeoStats.GetAsync().Result;
	var marsPhotos = nasaOpenApi.MarsPhotos.GetAsync(1000, CameraName.FHAZ).Result;
	var earthImage = nasaOpenApi.EarthImage.GetAsync(54.372158, 8.638306).Result;
	var earthAssets = nasaOpenApi.EarthAssets.GetAsync(54.372158, 8.638306).Result;

	Console.WriteLine("Results from Mars.Open.Api");
	Console.WriteLine($"Result APOD Url = {apodService.Url}");
	Console.WriteLine($"Result NEO COUNT = {statsService.NeoCount}");
	Console.WriteLine($"Result Mars Length = {marsPhotos.Photos.Length}");
	Console.WriteLine($"Result Earth DataLength = {earthImage.Length}");
	Console.WriteLine($"Result Earth Assets = {earthAssets.Resource.Dataset}");
	Console.WriteLine($"Api Remaining Calls = {nasaOpenApi.Remaining}");
	Console.WriteLine($"Api Limit Calls = {nasaOpenApi.Limit}");
     }
}
```


## License
[MIT](https://choosealicense.com/licenses/mit/)
