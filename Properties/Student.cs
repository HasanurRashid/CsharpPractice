using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private  int _id;
        private string Name { get; set; }

        private int Marks { get;}

        public int Id
        {
            get
            {
                return _id > 0 ? _id : 0;

            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Invalid number. Try again!");
                }
                _id = value;
            }
        }
       
    }
}
