using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Rabbit.Foundation.List
{
    [SuppressMessage("Microsoft.Naming", "CA1710", Justification = "Do not need to be ended with Collection on a list type")]
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

        /// <summary>
        ///  Returns a read-only collection.
        /// </summary>
        IReadOnlyCollection<T> AsReadOnly();
    }
}
