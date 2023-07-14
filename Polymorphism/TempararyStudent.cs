using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class TempararyStudent : Student
    {
        public override void FullName()
        {
            Console.WriteLine($"{firstName} {lastName} -Temp Class");
        }
    }
}
