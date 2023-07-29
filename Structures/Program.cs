// See https://aka.ms/new-console-template for more information




using Structures;

Person p = new Person(2);
p.Name = "Hasan";
p.ID = 100;
p.age = 90;

//Console.WriteLine(p.Name);
Person p2 = p;
Console.WriteLine( $"p2.Name = {p2.Name}, p.Name = {p.Name}");

p2.Name = "Test";

Console.WriteLine($"p2.Name = {p2.Name}, p.Name = {p.Name}");

