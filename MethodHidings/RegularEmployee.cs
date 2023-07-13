using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidings
{
    public class RegularEmployee : Employee
    {
        public new void printFullName()
        {
            base.printFullName();
            Console.WriteLine($"{firstName} {lastName} -regular");
        }
    }
}
