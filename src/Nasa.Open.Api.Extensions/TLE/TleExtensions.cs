namespace Nasa.Open.Api.Extensions.TLE
{
    using System;
    using Api.TLE.Models;

    public static class TleExtensions
    {
        public class TleTwoLineSatelliteCoordinates
        {
            public string Name { get; set; }

        }

        public static TleTwoLineSatelliteCoordinates ToSatelliteCoordinates(this TleMember value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.Line1) || string.IsNullOrWhiteSpace(value.Line2))
            {
                throw new ArgumentNullException("TleMember is wrong or missing Line1, Line2");
            }

            var tle = new TleTwoLineSatelliteCoordinates()
            {
                Name = value?.Name
            };
            
            return tle;
        }
    }
}
