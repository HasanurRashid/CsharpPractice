using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Student
    {
        public string firstName = "Hasanur";
        public string lastName = "Rashid";

        public virtual void FullName()
        {
            Console.WriteLine($"{firstName} {lastName} -Base Class");
        }
    }
}
