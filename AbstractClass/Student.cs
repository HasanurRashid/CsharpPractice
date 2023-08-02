using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Student : Teacher
    {
        public override void DoSomething(string a)
        {
            Console.WriteLine(a);
        }
    }
}
