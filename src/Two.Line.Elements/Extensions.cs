namespace Two.Line.Elements
{
    using System;
    public static class Extensions
    {
        public static string SkipLeft(this string value, int index)
        {
            return value.Substring(index, value.Length - index);
        }

        public static string FromRight(this string value, int index)
        {
            return value.Substring(value.Length - index, index);
        }

        /// <summary>
        /// Columns from string 1 based index
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static string Columns(this string value, int from, int to)
        {
            if (from < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(from));
            }

            return value.Substring(from - 1, to - from + 1);
        }
    }
}
