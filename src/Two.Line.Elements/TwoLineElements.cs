namespace Two.Line.Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LineParsers;
    using Model;

    public class TwoLineElements
    {
        public TwoLineElementsModel TwoLineElementsModel { get; set; }

        public TwoLineElements(TwoLineElementsModel twoLineElementsModel)
        {
            TwoLineElementsModel = twoLineElementsModel;
        }

        public static TwoLineElementsModel Parse(string lines)
        {
            if (string.IsNullOrWhiteSpace(lines))
            {
                throw new ArgumentNullException("lines is null, it shoult contain at least 2 lines https://pl.wikipedia.org/wiki/TLE");
            }

            var linesArray = lines.Split('\n').Where(s => !string.IsNullOrEmpty(s)).ToList();
            return Parse(linesArray);
        }

        public static TwoLineElementsModel Parse(Queue<string> lines)
        {
            if (lines == null)
            {
                throw new ArgumentNullException("lines");
            }

            if (lines.Count < Convert.ToInt32(Properties.Resources.TLE_MIN_LINE_COUNT))
            {
                throw new ArgumentException("Lines count is to low");
            }

            //TLE could be 3 lines, first than is satellite name
            if (lines.Count > Convert.ToInt32(Properties.Resources.TLE_MAX_LINE_COUNT))
            {
                throw new ArgumentOutOfRangeException("lines has more than 3 positions");
            }

            TwoLineElementsModel tle = new TwoLineElementsModel();


            if (lines.Count > Convert.ToInt32(Properties.Resources.TLE_MIN_LINE_COUNT))
            {
                tle.Name = TleLine0Parser.Parse(lines.Dequeue());
            }

            tle.Line1 = TleLine1Parser.Parse(lines.Dequeue());
            tle.Line2 = TleLine2Parser.Parse(lines.Dequeue());

            return tle;
        }

        public static TwoLineElementsModel Parse(List<string> lines)
        {
            return Parse(new Queue<string>(lines));
        }
    }
}
