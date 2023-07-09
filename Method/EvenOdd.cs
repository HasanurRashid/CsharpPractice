using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class EvenOdd
    {

        public int Add(int fn , int ln)
        {
            return fn + ln;
        }
        public static void EvenNumber(int n)
        {
            int start = 0;
            while (start<= n)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
