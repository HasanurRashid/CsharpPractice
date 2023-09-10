// See https://aka.ms/new-console-template for more information

using Reflection;
using System.Reflection;

Person p = new Person(2);
p.Name = "Hasan";
p.ID = 100;
p.age = 90;

//Console.WriteLine(p.Name);
Person p2 = p;
Console.WriteLine($"p2.Name = {p2.Name}, p.Name = {p.Name}");

p2.Name = "Test";

Console.WriteLine($"p2.Name = {p2.Name}, p.Name = {p.Name}");

Console.WriteLine();
Console.WriteLine("<<<<<<<<<<<<<<Reflection>>>>>>>>>>>>>>>");

Type t = Type.GetType("Structures.Test");


//Console.WriteLine($"Name:{t.Name} Full Name: {t.FullName}");

Console.WriteLine("<<<<<<<<<<<<<<Properties>>>>>>>>>>>>>>>");
//PropertyInfo[] propertiesInfos = t.GetProperties();

//foreach (PropertyInfo propertyInfo in propertiesInfos)
//{
//    Console.WriteLine(propertyInfo.Name);
//}




