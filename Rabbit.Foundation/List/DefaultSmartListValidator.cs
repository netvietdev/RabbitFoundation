using System.Collections.Generic;

namespace Rabbit.Foundation.List
{
    public class DefaultSmartListValidator<T> : ISmartListValidator<T>
    {
        protected readonly IEqualityComparer<T> Comparer;

        public DefaultSmartListValidator()
        {
        }

        public DefaultSmartListValidator(IEqualityComparer<T> comparer)
        {
            Comparer = comparer;
        }

        public virtual void OnBeforeAdd(ISmartList<T> list, T item)
        {
        }

        public virtual void OnReforeRemove(ISmartList<T> list, T item)
        {
        }
    }
}
