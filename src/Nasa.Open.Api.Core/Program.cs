using System;

namespace Nasa.Open.Api.Core
{
    class Program
    {
        private const string Api_key = "wc37Bqdjg1LUAwbYBYDpZE6XLuPvUlHYb274vmUs";
        
        static void Main(string[] args)
        {
            var api = new NasaOpenApi(Api_key);
            var res = api.Apod.GetAsync(DateTime.Now.AddDays(-11), true).Result;
            Console.WriteLine("Hello World!");
        }
    }
}
