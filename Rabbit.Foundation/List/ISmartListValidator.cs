namespace Rabbit.Foundation.List
{
    public interface ISmartListValidator
    {
        /// <summary>
        /// Performs validation tasks before adding item to list
        /// </summary>
        void OnBeforeAdd<T>(ISmartList<T> list, T item);

        /// <summary>
        /// Performs validation tasks before removing item from list
        /// </summary>
        void OnReforeRemove<T>(ISmartList<T> list, T item);
    }
}
