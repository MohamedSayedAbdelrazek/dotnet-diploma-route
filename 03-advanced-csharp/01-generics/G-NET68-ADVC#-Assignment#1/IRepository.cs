using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_ADVC__Assignment_1
{
    internal interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        List<T> GetAll();
    }
}
