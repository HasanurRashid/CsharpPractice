using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person
    {
        private readonly int _id;
        public int ID { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public Person(int id)
        {
            _id = id;
        }

        public string  GetFullName(string firstName,string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
