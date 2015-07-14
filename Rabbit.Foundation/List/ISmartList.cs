using System.Collections.Generic;

namespace Rabbit.Foundation.List
{
    public interface ISmartList<T> : IList<T>
    {
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
