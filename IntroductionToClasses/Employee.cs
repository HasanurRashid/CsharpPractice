using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToClasses
{
    public class Employee
    {
        public string _firsName;
        public string _lastName;

        //public Employee() : this("_firsName is empty", "_lastName is empty")
        //{
        //}

        public Employee()
        {

        }
        public Employee(string FirstName,string LastName) : this()
      {
            _firsName= FirstName;
            _lastName= LastName;
            /*
             this._firsName;
             this._lastName;
            */
        }

        public void FullName()
        {
            //Console.WriteLine("Full Name : {0}",FirstName + " "+ LastName);
            Console.WriteLine($"Full Name : {_firsName} {_lastName} ");
        }


        ~Employee()
        {

        }
    }
}
