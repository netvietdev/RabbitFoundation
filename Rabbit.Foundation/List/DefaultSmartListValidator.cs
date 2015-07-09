namespace Rabbit.Foundation.List
{
    public class DefaultSmartListValidator : ISmartListValidator
    {
        public virtual void OnBeforeAdd<T>(ISmartList<T> list, T item)
        {
        }

        public virtual void OnReforeRemove<T>(ISmartList<T> list, T item)
        {
        }
    }
}
