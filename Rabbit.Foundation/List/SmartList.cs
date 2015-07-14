using System.Collections;
using System.Collections.Generic;

namespace Rabbit.Foundation.List
{
    /// <summary>
    /// SmartList provides a way to perform validation logic before adding/removing items from the list.
    /// </summary>
    public class SmartList<T> : ISmartList<T>
    {
        private readonly ISmartListValidator<T> _validator;
        private readonly List<T> _items;

        public SmartList()
            : this(new DefaultSmartListValidator<T>())
        {
        }

        public SmartList(ISmartListValidator<T> validator)
        {
            _validator = validator;
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _validator.OnBeforeAdd(this, item);

            _items.Add(item);
        }

        public void Insert(int index, T item)
        {
            _validator.OnBeforeAdd(this, item);

            _items.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
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

        public int IndexOf(T item)
        {
            return _items.IndexOf(item);
        }

        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
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
            throw new System.NotImplementedException();
        }

        public bool IsReadOnly
        {
            get { return false; }
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
    }
}
