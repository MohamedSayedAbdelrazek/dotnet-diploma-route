using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace G_NET68_ADVC__Assignment_1
{
    internal class Container<T>
    {
        private List<T> _items;

        public Container(int size)
        {
            _items=new List<T>(size);
        }

        public void Add(T item) => _items.Add(item);
        public T? Get() => _items[0];


        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                return default;

            return _items[index];
        }

    }
}
