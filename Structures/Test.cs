using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
   

    public class Test
    {
        public static int Calculator(int firstNumber,int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int CalculatorNonStatic(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
