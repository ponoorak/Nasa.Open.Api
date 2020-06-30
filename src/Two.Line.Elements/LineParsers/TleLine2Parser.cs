namespace Two.Line.Elements.LineParsers
{
    using System;

    public static class TleLine2Parser
    {
        public class Line2Model
        {
            public int Line { get; set; }
            public double Number { get; set; }
            public double Inclination { get; set; }
            public double Ascension { get; set; }
            public double Eccentricity { get; set; }
            public double Perigee { get; set; }
            public double Anomaly { get; set; }
            public double Motion { get; set; }
            public double Revolution { get; set; }
        }

        public static Line2Model Parse(string line2)
        {
            if (string.IsNullOrEmpty(line2))
            {
                throw new ArgumentNullException(nameof(line2), @"line1 can't be empty");
            }

            if (line2.Length > 69)
            {
                throw new ArgumentOutOfRangeException("line0 exceeds 69 chars");
            }

            var checkSum = Convert.ToInt32(line2.Substring(68, 1));
            Utils.Checksum(line2, checkSum);

            var result = new Line2Model()
            {
                Line = Utils.ParseIntValue(line2.Columns(1, 1).Trim()),
                Number = Utils.ParseDoubleValue(line2.Columns(3, 7).Trim()),
                Inclination = Utils.ParseDoubleValue(line2.Columns(9, 16).Trim()),
                Ascension = Utils.ParseDoubleValue(line2.Columns(18, 25).Trim()),
                Eccentricity = Utils.ParseDoubleValue(line2.Columns(27, 33).Trim()),
                Perigee = Utils.ParseDoubleValue(line2.Columns(35, 42).Trim()),
                Anomaly = Utils.ParseDoubleValue(line2.Columns(44, 51).Trim()),
                Motion = Utils.ParseDoubleValue(line2.Columns(53, 63).Trim()),
                Revolution = Utils.ParseDoubleValue(line2.Columns(64, 68).Trim())
            };

            return result;
        }
    }
}
