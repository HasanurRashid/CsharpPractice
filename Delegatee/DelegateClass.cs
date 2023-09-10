using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatee
{
    public class DelegateClass
    {
        public delegate void DelegateDelegate(string message);

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
