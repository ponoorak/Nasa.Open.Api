using System;

namespace Nasa.Open.Api.Core
{
    class Program
    {
        //private const string Api_key = "wc37Bqdjg1LUAwbYBYDpZE6XLuPvUlHYb274vmUs";
        private const string Api_key = "DEMO_KEY";

        static void Main(string[] args)
        {
            var api = new NasaOpenApi(Api_key);
            //var res = api.Apod.GetAsync(DateTime.Now.AddDays(-11), true).Result;

            //var res2 = api.NeoFeed.GetAsync(DateTime.Parse("2015-09-07"), DateTime.Parse("2015-09-08")).Result;

            //var res3 = api.NeoLookup.GetAsync(3542519).Result;

            //var res4 = api.NeoToday.GetAsync().Result;
            var r = api.NeoSentry.GetAsync(3092104).Result;
            Console.WriteLine("Hello World!");
        }
    }
}
