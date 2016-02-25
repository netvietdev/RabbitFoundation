using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Rabbit.Uniquators
{
    static class IdGeneratorHelper
    {
        /// <summary>
        /// Generates Hexadecimal radix
        /// </summary>
        public static string NewId(IDictionary<ulong, IList<long>> cache, ulong current)
        {
            return NewId(cache, current, IdBase.Hexadecimal);
        }

        public static string NewId(IDictionary<ulong, IList<long>> cache, ulong current, IdBase radix)
        {
            // If all keys are precedent values, we should remove them from the dictionary
            // Otherwise cache contains current in the keys.
            // To ignore duplicated ID(s), we try to increase values in the list on each generation.

            if (cache.Count == 0)
            {
                cache.Add(current, new List<long>());
            }
            else if (cache.Keys.Max() < current)
            {
                cache.Clear();
                cache.Add(current, new List<long>());
            }
            else
            {
                // OK, do nothing
            }

            string secondPart;
            if (cache[current].Any())
            {
                var maxValue = cache[current].Max();
                cache[current].Add(maxValue + 1);
                secondPart = maxValue.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                cache[current].Add(0);
                secondPart = string.Empty;
            }

            var nextValueFormatted = string.Format("{0}{1}", current, secondPart);
            return NumberToString.Convert(UInt64.Parse(nextValueFormatted), radix);
        }
    }
}
