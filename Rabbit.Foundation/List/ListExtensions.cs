using System;
using System.Collections;

namespace Rabbit.Foundation.List
{
    public static class ListExtensions
    {
        /// <summary>
        /// Loop through each item in the list and perform the given action
        /// </summary>
        public static void Each(this IEnumerable items, Action<object> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }
    }
}