using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class Student<T>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEqualss(T value_1, T value_2)
        {
            return value_1.Equals(value_2);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() ^ this.Name.GetHashCode();
        }
    }
}
