using System;
using System.Collections.Generic;
using System.Linq;

namespace Rabbit.Foundation.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Gets a substring in smart way (seeks to the nearest space, dot, point, semicolom character)
        /// </summary>
        public static string GetSubstring(this string source, int length)
        {
            var defaultOptions = new List<string>()
            {
                " ",
                ".",
                ",",
                ";"
            };
            return source.GetSubstring(length, defaultOptions.ToArray());
        }

        /// <summary>
        /// Gets a substring with options to search (stop when at least an option characters is matched)
        /// </summary>
        public static string GetSubstring(this string source, int length, params string[] options)
        {
            if (string.IsNullOrEmpty(source))
            {
                return string.Empty;
            }

            if (source.Length <= length)
            {
                return source;
            }

            var indices =
                options.Select(
                    separator => source.IndexOf(separator, length, StringComparison.CurrentCultureIgnoreCase))
                    .Where(index => index >= 0)
                    .ToList();

            if (indices.Count > 0)
            {
                return source.Substring(0, indices.Min());
            }

            return source;
        }
    }
}
