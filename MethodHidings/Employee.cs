using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidings
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void printFullName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
