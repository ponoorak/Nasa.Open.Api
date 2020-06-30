namespace Nasa.Open.Api.Extensions.Tests
{
    using System;
    using APOD;
    using Xunit;

    public class ApodTests
    {
        [Fact]
        public void UrlTest()
        {
            var expected = new Uri("http://nasa.gov");
            var actual = new ApodModel()
            {
                Url = new Uri("http://nasa.gov")
            };

            Assert.Equal(expected, actual.ToUri());
        }

        [Fact]
        public void InvalidData()
        {
            ApodModel apod = null;
            Assert.Throws<ArgumentNullException>(() => apod.ToUri());

            apod = new ApodModel();
            Assert.Throws<ArgumentNullException>(() => apod.ToUri());
        }
    }
}
