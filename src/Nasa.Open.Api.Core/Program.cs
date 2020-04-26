using System;

namespace Nasa.Open.Api.Core
{
    class Program
    {
        //private const string Api_key = "wc37Bqdjg1LUAwbYBYDpZE6XLuPvUlHYb274vmUs";
        private const string ApiKey = "DEMO_KEY";

        static void Main(string[] args)
        {
            var api = new NasaOpenApi(ApiKey);
            var apodService = api.Apod.GetAsync(DateTime.Now.AddDays(-11), true).Result;
            var statsService = api.NeoStats.GetAsync().Result;

            Console.WriteLine($"Result APOD Url = {apodService.Url}");
            Console.WriteLine($"Result NEO COUNT = {statsService.NeoCount}");
            Console.WriteLine($"Api Remaining Calls = {api.Remaining}");
            Console.WriteLine($"Api Limit Calls = {api.Limit}");
        }
    }
}
