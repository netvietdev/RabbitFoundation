using System.Collections.Generic;

namespace Rabbit.Foundation.List
{
    public interface ISmartList<T> : IReadOnlyList<T>
    {
        /// <summary>
        /// Adds an item to the list
        /// </summary>
        void Add(T item);
        /// <summary>
        /// Removes the first occurrence of a specific object from the list
        /// </summary>
        void Remove(T item);
    }
}
