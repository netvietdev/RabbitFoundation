using System;
using System.Collections.Generic;
using System.Linq;

namespace Rabbit.Foundation.List
{
    public sealed class UniqueListValidator<T> : DefaultSmartListValidator<T>
    {
        public UniqueListValidator()
        {
        }

        public UniqueListValidator(IEqualityComparer<T> comparer)
            : base(comparer)
        {
        }

        public override void OnBeforeAdd(ISmartList<T> list, T item)
        {
            if (list.Contains(item, Comparer))
            {
                throw new ArgumentException("Item already exists", "item");
            }
        }
    }
}
