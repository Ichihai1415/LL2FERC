using System;

namespace LL2FERC
{
    /// <summary>
    /// The class that performs conversions.
    /// </summary>
    public partial class LL2FERC
    {
        /// <summary>
        /// Returns the Flinn-Engdahl regions code from latitude and longitude.
        /// </summary>
        /// <param name="lat">latitude</param>
        /// <param name="lon">longitude</param>
        /// <returns>Flinn-Engdahl regions code</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int GetCode(double lat, double lon)
        {
            if (lat < -90 || lat > 90 || double.IsNaN(lat))
                throw new ArgumentOutOfRangeException($"The specified argument \"lat\" is not in the valid range of values. ({lat})");
            if (lon < -180 || lon > 180 || double.IsNaN(lat))
                throw new ArgumentOutOfRangeException($"The specified argument \"lon\" is not in the valid range of values. ({lon})");
            var latIndex = (int)Math.Floor(90 - lat);
            var lonIndex = (int)Math.Floor(180 + lon);
            return Datas.Codes[latIndex, lonIndex];
        }

        /// <summary>
        /// Returns the Japanese name from the Flinn-Engdahl regions code.
        /// </summary>
        /// <param name="code">Flinn-Engdahl regions code</param>
        /// <returns>Japanese name corresponding to Flinn-Engdahl regions code</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string GetName_ja(int code)
        {
            if (code < 1 || code > 757)
                throw new ArgumentOutOfRangeException($"The specified argument \"code\" is not in the valid range of values. ({code})");
            return Datas.NameList_ja[code];
        }

        /// <summary>
        /// Returns the Japanese name from latitude and longitude.
        /// </summary>
        /// <param name="lat">latitude</param>
        /// <param name="lon">longitude</param>
        /// <returns>Japanese name corresponding to Flinn-Engdahl regions code</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string GetName_ja(double lat, double lon)
        {
            return Datas.NameList_ja[GetCode(lat, lon)];
        }

        /// <summary>
        /// Returns the English name from the Flinn-Engdahl regions code.
        /// </summary>
        /// <param name="code">Flinn-Engdahl regions code</param>
        /// <returns>English name corresponding to Flinn-Engdahl regions code</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string GetName_enUS(int code)
        {
            if (code < 1 || code > 757)
                throw new ArgumentOutOfRangeException($"The specified argument \"code\" is not in the valid range of values. ({code})");
            return Datas.NameList_enUS[code];
        }

        /// <summary>
        /// Returns the English name from the Flinn-Engdahl regions code.
        /// </summary>
        /// <param name="lat">latitude</param>
        /// <param name="lon">longitude</param>
        /// <returns>English name corresponding to Flinn-Engdahl regions code</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string GetName_enUS(double lat, double lon)
        {
            return Datas.NameList_enUS[GetCode(lat, lon)];
        }
    }
}