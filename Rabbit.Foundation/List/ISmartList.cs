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
        /// Inserts an item to the list at the specified index.
        /// </summary>
        void Insert(int index, T item);

        /// <summary>
        /// Removes the first occurrence of a specific object from the list
        /// </summary>
        void Remove(T item);

        /// <summary>
        /// Removes the item at the specified index from the list, returns removed item.
        /// </summary>
        T RemoveAt(int index);

        /// <summary>
        /// Move item up one position
        /// </summary>
        void MoveUp(T item);

        /// <summary>
        /// Move item down one position
        /// </summary>
        void MoveDown(T item);
    }
}
