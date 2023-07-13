using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void FullName()
        {
            Console.WriteLine(firstName+ " " + lastName);
        }
    }
}
