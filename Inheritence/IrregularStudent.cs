using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class IrregularStudent : Student
    {
        public int fine;

        public IrregularStudent(int fine)
        {
            this.fine = fine;
        }

        public void PrintFine()
        {
            Console.WriteLine($"Fine: {fine}");
        }
    
        //public IrregularStudent(int fine) : base(1,"Hasan","123456","hasan@gmail.com",30)
        //{
        //    this.fine = fine;
        //}

    }
}
