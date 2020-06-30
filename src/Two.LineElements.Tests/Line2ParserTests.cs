namespace Two.LineElements.Tests
{
    using System;
    using Line.Elements.LineParsers;
    using Xunit;

    public class Line2ParserTests
    {
        [Fact]
        public void InvalidParam()
        {
            Assert.Throws<ArgumentNullException>(() => TleLine2Parser.Parse(""));
        }

        [Fact]
        public void ParamToLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TleLine2Parser.Parse("1998-067PC               "));
        }

        [Fact]
        public void ValidParam()
        {
            //24 length 
            var line = "2 25544  51.6416 247.4627 0006703 130.5360 325.0288 15.72125391563537";
            var result = TleLine2Parser.Parse(line);
            Assert.Equal(2, result.Line);
            Assert.Equal(51.6416, result.Inclination);
            Assert.Equal(247.4627, result.Ascension);
            Assert.Equal(0006703, result.Eccentricity);
            Assert.Equal(130.5360, result.Perigee);
            Assert.Equal(325.0288, result.Anomaly);
            Assert.Equal(15.72125391, result.Motion);
            Assert.Equal(56353, result.Revolution);
        }
    }
}
