using System.Collections.Generic;
using System.IO;
using System.Linq;
using Rabbit.Foundation.Data;

namespace Rabbit.Foundation.Extensions
{
    public static class DataItemExtensions
    {
        public static bool TryGet(this IList<DataItem> items, string key, out DataItem result)
        {
            var count = items.Count(x => x.Key.Equals(key));

            if (count == 0)
            {
                result = null;
                return false;
            }

            if (count == 1)
            {
                result = items.Single(x => x.Key.Equals(key));
                return true;
            }

            throw new InvalidDataException("There are more than one instances with the same key in the list");
        }

        public static DataItem Get(this IList<DataItem> items, string key)
        {
            return items.SingleOrDefault(x => x.Key.Equals(key));
        }
    }
}