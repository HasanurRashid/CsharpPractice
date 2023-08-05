using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.UserClass;

namespace Delegates
{
    public class Employee
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        /* Q. What is Delegate? 
           Ans.: Delegate is a type safe function pointer.
        */

        public delegate bool IsPromotable(Employee emp);

        public static void PromotedEmployee(List<Employee> employees,IsPromotable isEligibleToPromote)
        {
            foreach (Employee emp in employees)
            {
                if (isEligibleToPromote(emp))
                {
                    Console.WriteLine($"{emp.Name} Promoted");
                }
            }
        }


    }
}
