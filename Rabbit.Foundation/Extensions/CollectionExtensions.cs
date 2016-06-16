using System.Collections.Generic;
using System.Dynamic;

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
    }
}