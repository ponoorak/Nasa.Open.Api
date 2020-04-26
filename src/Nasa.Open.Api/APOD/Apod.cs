namespace Nasa.Open.Api.APOD
{
    using System;
    using System.Threading.Tasks;
    using Attributes;
    using Extensions;

    [EndPoint(Consts.BASE_URL1, "planetary/apod")]
    internal class Apod: Base, IApod
    {
        public Apod(string apiKey, NasaOpenApiState state) :base(apiKey, state)
        {
            
        }

        public async Task<ApodModel> GetAsync(DateTime? date = null, bool highDefinition = false)
        {
            var messageArgs = new MessageArgs {{"hd", highDefinition ? "True" : "False"}};

            if (date != null)
            {
                messageArgs.Add("date", date.Value.ToDefault());
            }

            var result = await Request<ApodModel>(messageArgs);
            return result;
        }
    }
}
