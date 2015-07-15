using System.Collections.Generic;

namespace Rabbit.Foundation.List
{
    public class DefaultSmartListValidator<T> : ISmartListValidator<T>
    {
        protected IEqualityComparer<T> Comparer
        {
            get;
            private set;
        }

        public DefaultSmartListValidator()
            : this(EqualityComparer<T>.Default)
        {
        }

        public DefaultSmartListValidator(IEqualityComparer<T> comparer)
        {
            Comparer = comparer;
        }

        public virtual void OnBeforeAdd(ISmartList<T> list, T item)
        {
        }

        public void OnBeforeRemove(ISmartList<T> list, T item)
        {
        }
    }
}
