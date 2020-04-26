﻿using System;

namespace Nasa.Open.Api.Core
{
    using Mars.Photos;

    class Program
    {
        private const string ApiKey = "wc37Bqdjg1LUAwbYBYDpZE6XLuPvUlHYb274vmUs";
        //private const string ApiKey = "DEMO_KEY";

        static void Main(string[] args)
        {
            var api = new NasaOpenApi(ApiKey);
            var apodService = api.Apod.GetAsync().Result;
            var statsService = api.NeoStats.GetAsync().Result;
            var marsPhotos = api.MarsPhotos.GetAsync(1000, CameraName.FHAZ).Result;

            Console.WriteLine($"Result APOD Url = {apodService.Url}");
            Console.WriteLine($"Result NEO COUNT = {statsService.NeoCount}");

            Console.WriteLine($"Result Mars Length = {marsPhotos.Photos.Length}");
            Console.WriteLine($"Api Remaining Calls = {api.Remaining}");
            Console.WriteLine($"Api Limit Calls = {api.Limit}");
        }
    }
}
