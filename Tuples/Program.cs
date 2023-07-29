// See https://aka.ms/new-console-template for more information


using System.Net.Cache;

(int Age, string Name, decimal salary) person;

person.Name = "Hasan";
person.Age = 35;
person.salary = 30000;

Console.WriteLine($"Name : {person.Name} Age: {person.Age} Salary : {person.salary}");

var persons = (Age: 40,Name:"Jamal",Salary: 50000);

Console.WriteLine($"Name : {persons.Name} Age: {persons.Age} Salary : {persons.Salary}");

(int[] array,string name) something = (new int[] {1,2,4},"C Sharp");

Console.WriteLine(something.name, something.array);

