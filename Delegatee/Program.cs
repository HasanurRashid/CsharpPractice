// See https://aka.ms/new-console-template for more information


using Delegatee;
using static Delegatee.DelegateClass;
using static Delegatee.Employee;

DelegateClass delegateClass = new DelegateClass();

DelegateDelegate dele= new DelegateDelegate(delegateClass.PrintMessage);

dele("Salamun Alaik from delegate");

delegateClass.PrintMessage("Salam From Method");

List<Employee> employeeList = new List<Employee>();

employeeList.Add(new Employee() { Id = 1,Name="Hasan", Salary=3000,Experience = 5 });
employeeList.Add(new Employee() { Id = 2,Name="Mamun", Salary=3000,Experience = 3 });
employeeList.Add(new Employee() { Id = 3,Name="Mizan", Salary=3000,Experience = 4 });
employeeList.Add(new Employee() { Id = 4,Name="Ahsan", Salary=3000,Experience = 10 });

//IsPromotable isPromotable = new IsPromotable(IsEligibleToPromote); 

//Employee.PromptedEmployee(employeeList, isPromotable);
Employee.PromptedEmployee(employeeList, employee=>employee.Experience>=5);

//bool IsEligibleToPromote(Employee employee)
//{
//    if (employee.Experience >= 5)return true; else return false;
//}
