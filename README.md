# Nasa.Open.Api ![Release](https://github.com/ponoorak/Nasa.Open.Api/workflows/Release/badge.svg?branch=master) [![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg?)](https://github.com/ponoorak/Nasa.Open.Api/blob/master/LICENSE)

Unofficial .NET Wrapper for { NASA APIs } (https://api.nasa.gov)

Underdevelopment, now support: 
* APOD
* NEO
* MarsPhotos
* EarthPhotos
* EarthAssets
* TLE

# Instalation Nasa.Open.Api

```
Install-Package Nasa.Open.Api -Version 0.1.1
```

# Ussage Nasa.Open.Api

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
	var tle = nasaOpenApi.Tle.GetAsync().Result;

	Console.WriteLine("Results from Mars.Open.Api");
	Console.WriteLine($"Result APOD Url = {apodService.Url}");
	Console.WriteLine($"Result NEO COUNT = {statsService.NeoCount}");
	Console.WriteLine($"Result Mars Length = {marsPhotos.Photos.Length}");
	Console.WriteLine($"Result Earth DataLength = {earthImage.Length}");
	Console.WriteLine($"Result Earth Assets = {earthAssets.Resource.Dataset}");
	Console.WriteLine($"Result TLE Count = {tle.Member.Length}");
	Console.WriteLine($"Api Remaining Calls = {nasaOpenApi.Remaining}");
	Console.WriteLine($"Api Limit Calls = {nasaOpenApi.Limit}");
     }
}
```

# Instalation Tle parser

```
Install-Package Two.Line.Elements -Version 0.1.0
```

# Ussage Tle parser

```
var lines = "STARLINK-24\n" +
                       	"1 44238U 19029D   20182.10581531  .00001387  00000-0  94194-4 0  9999\n" +
                        "2 44238  52.9975 151.8469 0000937  68.7807 291.3284 15.13099176 60950";

TwoLineElementsModel result = TwoLineElements.Parse(lines);
```
Or
```
line0 = "STARLINK-24
var result = TleLine0Parser.Parse(line0)
```
Or
```
line1 = "1 25544U 98067A   08264.51782528 -.00002182  00000-0 -11606-4 0  2927";
var result = TleLine1Parser.Parse(line1)
```
Or
```
line2 = "2 25544  51.6416 247.4627 0006703 130.5360 325.0288 15.72125391563537";
var result = TleLine2Parser.Parse(line2)
```


## License
[MIT](https://choosealicense.com/licenses/mit/)
