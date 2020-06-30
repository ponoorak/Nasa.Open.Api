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

    internal class Connection
    {
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        private readonly string _apiKey;
        private readonly NasaOpenApiState _state;
        private static readonly HttpClient Client = new HttpClient();

        public Connection(string apiKey, NasaOpenApiState state)
        {
            _apiKey = apiKey;
            _state = state;
        }

        public async Task<HttpContent> Request(IReadOnlyDictionary<string, object> arguments = null, string suffix = "")
        {
            _logger.Trace("Request");

            var att = GetType().GetCustomAttribute<EndPointAttribute>();
            if (att == null)
            {
                throw new ApplicationException($"Missing EndPoint attribute in {this.GetType()}");
            }

            var builder = new UriBuilder(att.BaseAddress)
            {
                Path = !string.IsNullOrWhiteSpace(suffix) ?  att.Path + "/" + suffix : att.Path
            };

            var query = HttpUtility.ParseQueryString(builder.Query);
            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                query["api_key"] = _apiKey;
            }

            if (arguments != null)
            {
                foreach (var param in arguments)
                {
                    query[param.Key] = param.Value.ToString();
                }
            }

            builder.Query = query.ToString();

            _logger.Debug($"Call To {builder.Uri} {builder.Path}");
            var s = await Client.GetAsync(builder.Uri);

            _logger.Trace($"Return code: {s.StatusCode}");
            s.EnsureSuccessStatusCode();

            IEnumerable<string> val;
            if (s.Headers.TryGetValues("X-RateLimit-Remaining", out val))
            {
                _logger.Debug($"X-RateLimit-Remaining exists. Value {val}");
                _state.Remaining = Convert.ToInt32(val.FirstOrDefault());
            }

            if (s.Headers.TryGetValues("X-RateLimit-Limit", out val))
            {
                _logger.Debug($"X-RateLimit-Limit exists. Value {val}");
                _state.Limit = Convert.ToInt32(val.FirstOrDefault());
            }
            
            _logger.Debug($"Result Status Remaining:{_state.Remaining} Limit{_state.Limit}");

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
