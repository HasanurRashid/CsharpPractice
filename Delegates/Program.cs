// See https://aka.ms/new-console-template for more information



using Delegates;
using static Delegates.Employee;

//IsPromotable isPromotable = new IsPromotable(UserClass.Promote);




List<Employee> employeeList = new List<Employee>();

employeeList.Add(new Employee() { Id = 201, Name = "Hasan", Salary = 10000 });
employeeList.Add(new Employee() { Id = 201, Name = "Mamun", Salary = 20000 });
employeeList.Add(new Employee() { Id = 201, Name = "Tareq", Salary = 30000 });
employeeList.Add(new Employee() { Id = 201, Name = "Aziz", Salary = 40000 });
employeeList.Add(new Employee() { Id = 201, Name = "Hasan vai", Salary = 50000 });

//Employee.PromotedEmployee(employeeList, isPromotable);
Employee.PromotedEmployee(employeeList, emp =>emp.Salary>500);




