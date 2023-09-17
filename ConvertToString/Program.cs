// See https://aka.ms/new-console-template for more information

using ConvertToString;

Employee employee = new Employee();

Employee employee2 = null;

string rslt = Convert.ToString(employee);
Console.WriteLine(rslt);

string rslt2 = Convert.ToString(employee2);
Console.WriteLine(rslt2);

string rslt3 = employee2.ToString();
Console.WriteLine(rslt3);