using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Member : IMember, IMember2, IMember3
    {
        public string Name(string name)
        {
            throw new NotImplementedException();
        }

        void IMember3.Print()
        {
            throw new NotImplementedException();
        }

        void Print(string message)
        {
            throw new NotImplementedException();
        }

        void IMember2.Print(string message) { 
        }

        void IMember.Print(string message)
        {
            throw new NotImplementedException();
        }
    }
}
