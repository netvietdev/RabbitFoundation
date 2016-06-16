using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Rabbit.Foundation.Extensions
{
    public static class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
            }
        }

        public static object ToDynamicObject(this IDictionary<string, object> source)
        {
            ICollection<KeyValuePair<string, object>> someObject = new ExpandoObject();
            someObject.AddRange(source);
            return someObject;
        }

        /// <summary>
        /// Convert a list of lines of string to dictionary. Take the first equal sign to separate the key and value
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when a line does not contain equal sign</exception>
        public static IDictionary<string, string> ToDictionary(this IEnumerable<string> lines)
        {
            var result = new Dictionary<string, string>();

            foreach (var line in lines.Where(x => !string.IsNullOrWhiteSpace(x)))
            {
                if (!line.Contains("="))
                {
                    throw new ArgumentException(string.Format("The line '{0}' must contain at least one equal sign", line));
                }

                var parts = line.Split(new[] { '=' }, 2);
                result.Add(parts[0].Trim(), parts[1].Trim());
            }

            return result;
        }
    }
}
