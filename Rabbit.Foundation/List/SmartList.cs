using System.Collections;
using System.Collections.Generic;

namespace Rabbit.Foundation.List
{
    /// <summary>
    /// SmartList provides a way to perform validation logic before adding/removing items from the list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SmartSmartList<T> : ISmartList<T>
    {
        private readonly ISmartListValidator _validator;
        private readonly List<T> _items;

        public SmartSmartList()
            : this(new DefaultSmartListValidator())
        {
        }

        public SmartSmartList(ISmartListValidator validator)
        {
            _validator = validator;
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _validator.OnBeforeAdd(this, item);

            _items.Add(item);
        }

        public void Remove(T item)
        {
            _validator.OnReforeRemove(this, item);

            _items.Remove(item);
        }

        public T this[int index]
        {
            get { return _items[index]; }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
