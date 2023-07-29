using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    public class TestClass
    {

        public int GetSum(params int[] sum)
        {
            int summ = 0;
            foreach(var value in sum)
            {
                summ += value;
            }
            return summ;
        }
    }
}
