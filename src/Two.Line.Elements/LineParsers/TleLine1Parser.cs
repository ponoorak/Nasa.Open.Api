namespace Two.Line.Elements.LineParsers
{
    using System;
    using System.Linq;

    public static class TleLine1Parser
    {
        /// <summary>
        /// Classification (U=Unclassified, C=Classified, S=Secret) 
        /// </summary>
        public enum Classification
        {
            Unclassified = 'U',
            Classified = 'C',
            Secret = 'S'
        }

        public class Line1Model
        {
            public int Line { get; set; }
            public double Number { get; set; }
            public Classification Classification { get; set; }
            public string Id { get; set; }
            public DateTime Date { get; set; }
            public double FirstDerivativeMeanMotion { get; set; }
            public double SecondDerivativeMeanMotion { get; set; }
            public double DragTermRadiationPressure { get; set; }
            public int EphemerisType { get; set; }
            public int ElementSetNumber { get; set; }
        }

        

        public static Line1Model Parse(string line1)
        {
            if (string.IsNullOrEmpty(line1))
            {
                throw new ArgumentNullException(nameof(line1),@"line1 can't be empty");
            }

            if (line1.Length > 69)
            {
                throw new ArgumentOutOfRangeException("line0 exceeds 69 chars");
            }

            var checkSum = Convert.ToInt32(line1.Columns(69, 69));
            Utils.Checksum(line1, checkSum);

            var result = new Line1Model
            {
                Line = Utils.ParseIntValue(line1.Columns(1, 1)),
                Number = Utils.ParseDoubleValue(line1.Columns(3, 7)),
                Classification = (Classification) line1.Columns(8, 8).First(),
                Id = line1.Columns(10, 17).Trim(),
                Date = Utils.JulianToDateTimeUtc(line1.Columns(18, 32).Trim()),
                FirstDerivativeMeanMotion = Utils.ParseDoubleValue(line1.Columns(34, 43)),
                SecondDerivativeMeanMotion = Utils.ParseFloatValue(line1.Columns(45, 52).Trim()),
                DragTermRadiationPressure = Utils.ParseFloatValue(line1.Columns(54, 61).Trim()),
                EphemerisType = Utils.ParseIntValue(line1.Columns(63, 63).Trim()),
                ElementSetNumber = Utils.ParseIntValue(line1.Columns(65, 68).Trim())
            };

            return result;
        }
    }
}
