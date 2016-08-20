using System.Collections;
using System.Collections.Generic;

namespace ResharperTalk.Classes
{
    public class LoggingList<T> : IList<T>
    {
        private IList<T> _listImplementation;

        public LoggingList(IList<T> listImplementation)
        {
            _listImplementation = listImplementation;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _listImplementation.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _listImplementation).GetEnumerator();
        }

        public void Add(T item)
        {
            System.Console.WriteLine($"Hey! I added an item: {item}");
            _listImplementation.Add(item);
        }

        public void Clear()
        {
            _listImplementation.Clear();
        }

        public bool Contains(T item)
        {
            return _listImplementation.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _listImplementation.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _listImplementation.Remove(item);
        }

        public int Count
        {
            get { return _listImplementation.Count; }
        }

        public bool IsReadOnly
        {
            get { return _listImplementation.IsReadOnly; }
        }

        public int IndexOf(T item)
        {
            return _listImplementation.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _listImplementation.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _listImplementation.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _listImplementation[index]; }
            set { _listImplementation[index] = value; }
        }
    }
}