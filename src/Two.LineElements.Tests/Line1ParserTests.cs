namespace Two.LineElements.Tests
{
    using System;
    using Line.Elements.LineParsers;
    using Xunit;

    public class Line1ParserTests
    {
        [Fact]
        public void InvalidParam()
        {
            Assert.Throws<ArgumentNullException>(() => TleLine1Parser.Parse(""));
        }

        [Fact]
        public void ParamToLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TleLine1Parser.Parse("2 25544  51.6416 247.4627 0006703 130.5360 325.0288 15.72125391563537 "));
        }

        [Fact]
        public void ValidParam()
        {
            var line = "1 25544U 98067A   08264.51782528 -.00002182  00000-0 -11606-4 0  2927";
            var result = TleLine1Parser.Parse(line);
            Assert.Equal(1, result.Line);
            Assert.Equal(25544, result.Number);
            Assert.Equal(TleLine1Parser.Classification.Unclassified, result.Classification);
            Assert.Equal(-2.182E-05, result.FirstDerivativeMeanMotion);
            Assert.Equal(0, result.SecondDerivativeMeanMotion);
            Assert.Equal(-0.11606E-4, result.DragTermRadiationPressure);
            Assert.Equal(0, result.EphemerisType);
            Assert.Equal(292, result.ElementSetNumber);
        }
    }
}
