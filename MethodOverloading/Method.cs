using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public static class Method
    {
        public static void Add(int fn, int sn)
        {
            Console.WriteLine(fn + sn);

        }
        public static void Add(int fn,int sn,out int sum,out int multi)
        {
            sum = fn + sn;
            multi = fn*sn;  
           
        }

        public static void Add(int fn, int sn, out int multi)
        {
         
            multi = fn * sn;

        }
    }
}
