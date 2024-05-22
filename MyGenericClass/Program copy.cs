using System;

namespace MyGenericClass
{
    public class Guarda3<T>
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

        
    }
}
