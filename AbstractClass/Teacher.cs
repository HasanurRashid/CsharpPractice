using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Teacher : Gurdian, ITeacher
    {
        public readonly string _name; // -- Accepted by Abstract Class
        public abstract void DoSomething(string a);
        
        public void DoSomething()
        {
            Console.WriteLine("This is non abstract method in abstract Class");
        }

        //public void Print()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
