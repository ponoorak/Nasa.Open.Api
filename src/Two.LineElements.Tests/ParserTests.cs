using System;
using Xunit;

namespace Two.LineElements.Tests
{
    using System.Collections.Generic;
    using System.Reflection.Metadata;
    using Line.Elements;

    public class ParserTests
    {
        [Fact]
        public void ParseValidStringTests()
        { 
            string lines = "1998-067PC\n" +
                           "1 43554U 98067PC  20118.45620883  .00054942  00000-0  30671-3 0  9993\n" +
                           "2 43554  51.6306 180.8546 0004705 314.5821  45.4795 15.78827646101882";

            var r = TwoLineElements.Parse(lines);

            Assert.Equal("1998-067PC", r.Name);
        }

        [Fact]
        public void ParseValidStringTest2()
        {
            var lines = "ISS (ZARYA)\n" +
                        "1 25544U 98067A   08264.51782528 -.00002182  00000-0 -11606-4 0  2927\n" +
                        "2 25544  51.6416 247.4627 0006703 130.5360 325.0288 15.72125391563537";

            var r = TwoLineElements.Parse(lines);

            Assert.Equal("ISS (ZARYA)", r.Name);
        }

        [Fact]
        public void ParseValidStringTest3()
        {
            var lines = "STARLINK-24\n" +
                        "1 44238U 19029D   20182.10581531  .00001387  00000-0  94194-4 0  9999\n" +
                        "2 44238  52.9975 151.8469 0000937  68.7807 291.3284 15.13099176 60950";

            var r = TwoLineElements.Parse(lines);

            Assert.Equal("STARLINK-24", r.Name);
        }

        [Fact]
        public void ParseInvalidArray()
        {
            List<string> stringArr = null;
            Assert.Throws<ArgumentNullException>(() => TwoLineElements.Parse(stringArr));

            stringArr = new List<string>() {"asd"};
            Assert.Throws<ArgumentException>(() => TwoLineElements.Parse(stringArr));

            stringArr = new List<string>() { "asd" , "asd", "asd", "asd"};
            Assert.Throws<ArgumentOutOfRangeException>(() => TwoLineElements.Parse(stringArr));

        }

        [Fact]
        public void ParseInvalidString()
        {
            string linesStr = String.Empty;
            Assert.Throws<ArgumentNullException>(() => TwoLineElements.Parse(linesStr));

            linesStr = "asd\nasd\nasd\nasd";
            Assert.Throws<ArgumentOutOfRangeException>(() => TwoLineElements.Parse(linesStr));

            linesStr = "asd\n";
            Assert.Throws<ArgumentException>(() => TwoLineElements.Parse(linesStr));
        }
    }
}
