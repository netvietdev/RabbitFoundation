using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Rabbit.Foundation.List
{
	[SuppressMessage("Microsoft.Naming", "CA1710", Justification = "Do not need to have Collection at the end")]    
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
