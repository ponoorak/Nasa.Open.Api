namespace Nasa.Open.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Web;
    using Attributes;
    using Newtonsoft.Json;
    using NLog;

    internal class Base
    {
        private readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        private readonly string _apiKey;
        private NasaOpenApiState _state;
        private static HttpClient Client = new HttpClient();

        public Base(string apiKey, NasaOpenApiState state)
        {
            _apiKey = apiKey;
            _state = state;
        }

        public async Task<TReturn> Request<TReturn>(IReadOnlyDictionary<string, object> arguments = null)
        {
            Logger.Trace("Request");

            var att = GetType().GetCustomAttribute<EndPointAttribute>();

            var builder = new UriBuilder(att.BaseAddress)
            {
                Path = att.Path
            };

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["api_key"] = _apiKey;
            if (arguments != null)
            {
                foreach (var param in arguments)
                {
                    query[param.Key] = param.Value.ToString();
                }
            }

            builder.Query = query.ToString();

            Logger.Debug($"Call To {builder.Uri} {builder.Path}");
            var s = await Client.GetAsync(builder.Uri);

            Logger.Trace($"Return code: {s.StatusCode}");
            s.EnsureSuccessStatusCode();
            _state.Remaining = Convert.ToInt32(s.Headers.GetValues("X-RateLimit-Remaining").FirstOrDefault());
            _state.Limit = Convert.ToInt32(s.Headers.GetValues("X-RateLimit-Limit").FirstOrDefault());
            var response = await s.Content.ReadAsStringAsync();
            
            Logger.Trace($"Response code: {response}");
            return JsonConvert.DeserializeObject<TReturn>(response);
        }
    }
}
