using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Rabbit.Foundation.List
{
    /// <summary>
    /// SmartList provides a way to perform validation logic before adding/removing items from the list.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1710", Justification = "Do not need to be ended with Collection on a list type")]
    public class SmartList<T> : ISmartList<T>
    {
        private readonly ISmartListValidator<T> _validator;
        private readonly IList<T> _items;

        public SmartList()
            : this(new List<T>(), new DefaultSmartListValidator<T>())
        {
        }

        public SmartList(IList<T> items)
            : this(items, new DefaultSmartListValidator<T>())
        {
        }

        public SmartList(ISmartListValidator<T> validator)
            : this(new List<T>(), validator)
        {
        }

        public SmartList(IList<T> items, ISmartListValidator<T> validator)
        {
            _items = items;
            _validator = validator;
        }

        public void MoveUp(T item)
        {
            var index = _items.IndexOf(item);
            if (index <= 0)
            {
                return;
            }
            _items.RemoveAt(index);
            _items.Insert(index - 1, item);
        }

        public void MoveDown(T item)
        {
            var index = _items.IndexOf(item);
            if (index >= _items.Count - 1)
            {
                return;
            }
            _items.RemoveAt(index);
            _items.Insert(index, item);
        }

        public IReadOnlyCollection<T> AsReadOnly()
        {
            return _items.ToList().AsReadOnly();
        }

        public int IndexOf(T item)
        {
            return _items.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _validator.OnBeforeAdd(this, item);
            _items.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            var item = _items[index];

            _validator.OnBeforeRemove(this, item);
            _items.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        public void Add(T item)
        {
            _validator.OnBeforeAdd(this, item);
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public bool IsReadOnly
        {
            get { return _items.IsReadOnly; }
        }

        public bool Remove(T item)
        {
            _validator.OnBeforeRemove(this, item);
            return _items.Remove(item);
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
