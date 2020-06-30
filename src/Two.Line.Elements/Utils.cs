namespace Two.Line.Elements
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using Exceptions;

    public static class Utils
    {
        /// <summary>
        /// Checksum Calculate according https://en.wikipedia.org/wiki/Two-line_element_set
        /// </summary>
        /// <param name="line"></param>
        /// <param name="expected">expected checksum from 68-69 line position</param>
        /// <returns></returns>
        public static void Checksum(string line, int expected)
        {
            var chak = Checksum(line);
            if (chak != expected)
            {
                throw new ChecksumException(expected, chak);
            }
        }

        public static int Checksum(string line)
        {
            int sum = 0;
            foreach (char c in line.Substring(0, 68))
            {
                if (c == '-')
                {
                    sum++;
                    continue;
                }
                else if (Char.IsDigit(c))
                {
                    sum += (byte)Char.GetNumericValue(c);
                }
            }

            return sum % 10;
        }


        public static int ParseIntValue(string value)
        {
            return Convert.ToInt32(value);
        }

        public static double ParseDoubleValue(string value)
        {
            var pattern = @"([-])?([\.\d]+)([+-]\d+)?";
            var r = new Regex(pattern);
            var match = r.Match(value);
            return Convert.ToDouble(match.Value);
        }

        public static double ParseFloatValue(string value)
        {
            var val1 = value.Columns(1, 1);
            var val2 = value.Substring(1, value.Length - 3);
            var val3 = value.FromRight(2);
            var val = val1 + '.' + val2 + 'e' + val3;
            return Convert.ToDouble(val);
        }

        public static DateTime JulianToDateTimeUtc(string dateLine)
        {
            if (string.IsNullOrEmpty(dateLine) || dateLine.Length != 14)
            {
                throw new IndexOutOfRangeException(dateLine);
            }

            var epoch = ParseIntValue(dateLine.Substring(0, 2));
            var days = ParseDoubleValue(dateLine.SkipLeft(2));

            var year = DateTime.Now.Year;
            var currentEpoch = year % 100;
            var century = year - currentEpoch;
            year = epoch > currentEpoch + 1 ? century - 100 + epoch : century + epoch;

            var day = (int)Math.Floor(days);
            var hours = 24 * (days - day);
            var hour = (int)Math.Floor(hours);
            var minutes = 60 * (hours - hour);
            var minute = (int)Math.Floor(minutes);
            var seconds = 60 * (minutes - minute);
            var second = (int)Math.Floor(seconds);
            var miliSeconds = 1000 * (seconds - second);
            
            var date = new DateTime(year, 1, 1, hour, minute, second) + TimeSpan.FromDays(day) + TimeSpan.FromMilliseconds(miliSeconds);
            return DateTime.SpecifyKind(date.AddDays(-1), DateTimeKind.Utc);
        }
    }
}
