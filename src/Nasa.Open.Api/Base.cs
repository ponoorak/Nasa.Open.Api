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
        private readonly NasaOpenApiState _state;
        private static readonly HttpClient _client = new HttpClient();

        public Base(string apiKey, NasaOpenApiState state)
        {
            _apiKey = apiKey;
            _state = state;
        }

        public async Task<HttpContent> Request(IReadOnlyDictionary<string, object> arguments = null, string suffix = "")
        {
            Logger.Trace("Request");

            var att = GetType().GetCustomAttribute<EndPointAttribute>();
            if (att == null)
            {
                throw new ApplicationException($"Missing EndPoint attribute in {this.GetType()}");
            }

            var builder = new UriBuilder(att.BaseAddress)
            {
                Path = att.Path + "/" + suffix
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
            var s = await _client.GetAsync(builder.Uri);

            Logger.Trace($"Return code: {s.StatusCode}");
            s.EnsureSuccessStatusCode();
            _state.Remaining = Convert.ToInt32(s.Headers.GetValues("X-RateLimit-Remaining").FirstOrDefault());
            _state.Limit = Convert.ToInt32(s.Headers.GetValues("X-RateLimit-Limit").FirstOrDefault());

            Logger.Debug($"Result Status Remaining:{_state.Remaining} Limit{_state.Limit}");

            return s.Content;

        }

        public async Task<TReturn> Request<TReturn>(IReadOnlyDictionary<string, object> arguments = null, string suffix = "")
        {
            var content = await Request(arguments, suffix);
            var response = await content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TReturn>(response);
        }

        public async Task<byte[]> RequestBinary(IReadOnlyDictionary<string, object> arguments = null, string suffix = "")
        {
            var content = await Request(arguments, suffix);
            return await content.ReadAsByteArrayAsync();
        }
    }
}
