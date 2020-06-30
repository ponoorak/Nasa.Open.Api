namespace Nasa.Open.Api.Extensions
{
    using System;
    using APOD;

    public static class ApodExtensions
    {
        public static Uri ToUri(this ApodModel apod)
        {
            if (apod == null || apod.Url == null)
            {
                throw new ArgumentNullException("invalid APOD result");
            }

            return apod.Url;
        }
    }
}
