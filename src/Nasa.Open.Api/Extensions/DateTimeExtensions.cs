using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.Open.Api.Extensions
{
    internal static class DateTimeExtensions
    {
        /// <summary>
        /// Return default api.nasa format "yyyy-MM-DD
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToDefault(this DateTime date)
        {
            return date.ToString(Properties.Resources.DefaultApiDateFormat);
        }
    }
}
