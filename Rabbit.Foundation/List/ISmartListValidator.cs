namespace Rabbit.Foundation.List
{
    public interface ISmartListValidator<T>
    {
        /// <summary>
        /// Performs validation tasks before adding item to list
        /// </summary>
        void OnBeforeAdd(ISmartList<T> list, T item);

        /// <summary>
        /// Performs validation tasks before removing item from list
        /// </summary>
        void OnReforeRemove(ISmartList<T> list, T item);
    }
}
