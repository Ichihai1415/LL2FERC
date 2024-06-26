﻿using System;
using System.Collections.Generic;
using System.IO;

namespace LL2FERC
{
    /// <summary>
    /// The base class for this library. Basic functions are provided as static method in this class.
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

        /// <summary>
        /// The class to read a file and get its name. Class instance must be created.
        /// </summary>
        public class FromFile
        {
            /// <summary>
            /// Read the file(LL2FERC.FromFile.csv) and initialize the list of names.
            /// </summary>
            /// <exception cref="FileNotFoundException"></exception>
            /// <exception cref="Exception"></exception>
            public FromFile()
            {
                new FromFile("LL2FERC.FromFile.csv");
            }

            /// <summary>
            /// Read the file the specified path and initialize the list of names.
            /// </summary>
            /// <exception cref="FileNotFoundException"></exception>
            /// <exception cref="Exception"></exception>
            public FromFile(string path)
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException("Place name data file in the same directory as LL2FERC.dll. Check NuGet or GitHub detail page for more information.", path);

                try
                {
                    var fileTexts = File.ReadAllLines(path);
                    for (int i = 1; i <= 757; i++)
                    {
                        var fileText_cn = fileTexts[i].Split(',');
                        NameList_File.Add(int.Parse(fileText_cn[0]), fileText_cn[1]);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to initialize the name list. Please check the contents of the file.", ex);
                }
            }

            /// <summary>
            /// List of names read from the file. [code, name]
            /// </summary>
            public Dictionary<int, string> NameList_File = new Dictionary<int, string>();

            /// <summary>
            /// Returns the name read from the file from the Flinn-Engdahl regions code.
            /// </summary>
            /// <param name="code">Flinn-Engdahl regions code</param>
            /// <returns>name read from the file corresponding to Flinn-Engdahl regions code</returns>
            /// <exception cref="ArgumentOutOfRangeException"></exception>
            public string GetName_File(int code)
            {
                if (code < 1 || code > 757)
                    throw new ArgumentOutOfRangeException($"The specified argument \"code\" is not in the valid range of values. ({code})");
                return NameList_File[code];
            }

            /// <summary>
            /// Returns the name read from the file from the Flinn-Engdahl regions code.
            /// </summary>
            /// <param name="lat">latitude</param>
            /// <param name="lon">longitude</param>
            /// <returns>name read from the file corresponding to Flinn-Engdahl regions code</returns>
            /// <exception cref="ArgumentOutOfRangeException"></exception>
            public string GetName_File(double lat, double lon)
            {
                return NameList_File[GetCode(lat, lon)];
            }
        }
    }
}