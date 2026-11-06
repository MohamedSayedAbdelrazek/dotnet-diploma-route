using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_ADVC__Assignment_1
{
    internal class Pair<Tkey,Tvalue>
    {
        public Pair(Tkey first, Tvalue second)
        {
            First = first;
            Second = second;
        }

        public Tkey First { get; set; }
        public Tvalue Second { get; set; }

        
    }
}
