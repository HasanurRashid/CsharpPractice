using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct Person 
    {
        private readonly int _id;
        public int ID { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public Person(int id)
        {
            _id= id;
        }

        
    }
}
