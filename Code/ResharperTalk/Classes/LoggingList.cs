using System;
using System.Collections;
using System.Collections.Generic;

namespace ResharperTalk.Classes
{
    public class LoggingList<T> : IList<T>
    {
        public LoggingList(IList<T> internalList)
        {
            this.internalList = internalList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return internalList.GetEnumerator();
        }

        public void Add(T item)
        {
            Console.WriteLine(item);
            internalList.Add(item);
        }

        public void Clear()
        {
            internalList.Clear();
        }

        public bool Contains(T item)
        {
            return internalList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            internalList.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return internalList.Remove(item);
        }

        public int Count => internalList.Count;

        public bool IsReadOnly => internalList.IsReadOnly;

        public int IndexOf(T item)
        {
            return internalList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            internalList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            internalList.RemoveAt(index);
        }

        public T this[int index]
        {
            get => internalList[index];
            set => internalList[index] = value;
        }

        private IList<T> internalList;
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) internalList).GetEnumerator();
        }
    }
}