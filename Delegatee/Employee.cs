using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public delegate bool IsPromotable(Employee employee);


        public static void PromptedEmployee(List<Employee> employeeList, IsPromotable isProomotable)
        {
            foreach (Employee emp in employeeList)
            {
                if (isProomotable(emp))
                {
                    Console.WriteLine($"{emp.Name} promoted");
                }
            }
        }

        //public static void PromptedEmployee(List<Employee> employeeList)
        //{
        //    foreach(Employee emp in employeeList)
        //    {
        //        if(emp.Experience>=5)
        //        {
        //            Console.WriteLine($"{emp.Name} promoted");
        //        }
        //    }
        //}
    }
}
