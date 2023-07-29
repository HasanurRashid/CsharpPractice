using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class Coordinate<T,Q> where T : class, new() where Q : struct
    {
        public T Age { get; set; }
        public Q Name { get; set; }

        public void Add<K>(K value)
        {
            T t;
            Q q;
            K k;
        }


    }
}
