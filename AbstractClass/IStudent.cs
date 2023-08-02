using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public interface IStudent : ITeacher  // Teacher -- Here The Teacher Class is an abstract. That's why Interface cannot inherit from the teacher class
    {
    }
}
