using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Student
    {
        private readonly  int _id;
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Student(int id)
        {
            this._id = id;
        }
    }
}
