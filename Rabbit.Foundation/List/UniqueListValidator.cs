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
            var isContained = (Comparer == null) ? list.Contains(item) : list.Contains(item, Comparer);

            if (isContained)
            {
                throw new ArgumentException("Item already exists", "item");
            }
        }
    }
}
