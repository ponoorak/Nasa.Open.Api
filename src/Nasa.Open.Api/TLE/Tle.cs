namespace Nasa.Open.Api.TLE
{
    using Attributes;
    using Models;
    using System.Threading.Tasks;

    public class FieldValue
    {
        public string Value { get; }
        public FieldValue(string field)
        {
            Value = field;
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public class SortField : FieldValue
    {
        public static SortField Id { get; } = new SortField("id");
        public static SortField Name { get; } = new SortField("name");
        private SortField(string key) : base(key) { }
    }

    public class SortDirection : FieldValue
    {
        public static SortDirection Asc { get; } = new SortDirection("asc");
        public static SortDirection Desc { get; } = new SortDirection("desc");
        private SortDirection(string key) : base(key) { }
    }

    /// <summary>
    /// The TLE API provides up to date two line element set records, the data is updated daily from CelesTrak and served in JSON format
    /// </summary>
    public interface ITle
    {
        Task<TleResult> GetAsync(string query = "*");

        Task<TleResult> GetAsync(string query, SortField sortField, SortDirection sortDirection, int page,
            int pageSize, string pseudoRandomNoise = null);
    }


    [EndPoint(Consts.BASE_TLE, "api/tle")]
    internal class Tle : Connection, ITle
    {
        public async Task<TleResult> GetAsync(string query = "*")
        {
            return await GetAsync(query, SortField.Name, SortDirection.Asc, 1, 50);
        }

        public async Task<TleResult> GetAsync(string query, SortField sortField, SortDirection sortDirection, int page, int pageSize, string pseudoRandomNoise = null)
        {
            var message = new MessageArgs();

            if (!string.IsNullOrWhiteSpace(query))
            {
                message.Add("search", query);
            }

            if (!string.IsNullOrWhiteSpace(pseudoRandomNoise))
            {
                message.Add("prn", pseudoRandomNoise);

            }

            message.Add("sort", sortField);
            message.Add("sort-dir", sortDirection);
            message.Add("page", page);
            message.Add("page-size", pageSize);

            var result = await Request<TleResult>(message);
            return result;
        }

        public Tle(NasaOpenApiState state) : base("", state)
        {
        }
    }
}
