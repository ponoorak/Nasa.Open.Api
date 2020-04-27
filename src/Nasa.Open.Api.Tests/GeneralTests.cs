namespace Nasa.Open.Api.Tests
{
    using System;
    using Xunit;

    public class GeneralTests
    {
        [Fact]
        public void ApiKeyLengthTest()
        {
            Assert.Throws<ArgumentException>(()=> new NasaOpenApi("").Apod.GetAsync().Result);
        }

        [Fact(Skip = "Need Internet Connection... fix to moc")]
        public void ApiKeyInvalidTest()
        {
            Assert.Throws<AggregateException>(() => new NasaOpenApi("DEMO_YEK").Apod.GetAsync().Result);
        }
    }
}
