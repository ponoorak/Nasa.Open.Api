using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.Open.Api.Framework
{
    class Program
    {
        private const string Api_key = "wc37Bqdjg1LUAwbYBYDpZE6XLuPvUlHYb274vmUs";
        static void Main(string[] args)
        {
            var nasa = new NasaOpenApi(Api_key);
            var r = nasa.Apod.GetAsync().Result;
            Console.WriteLine("Hello World!");
        }
    }
}
