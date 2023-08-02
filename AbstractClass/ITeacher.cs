using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public interface ITeacher 
    {
        //public int myField;  -- not accepted
        public void Print()
        {
            Console.WriteLine();
        }
    }
}
