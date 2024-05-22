using System;
using System.Collections;
using System.Collections.Generic;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T _item1;
        private T _item2;
        private T _item3;

        public Guarda3()
        {
            _item1 = default(T);
            _item2 = default(T);
            _item3 = default(T);
        }

        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            return i == 0? _item1 : i == 1? _item2 : _item3;
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            if (i == 0)
            {
                _item1 = item;
            }
            else if (i == 1)
            {
                _item2 = item;
            }
            else
            {
                _item3 = item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return _item1;
            yield return _item2;
            yield return _item3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
