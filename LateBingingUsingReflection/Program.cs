// See https://aka.ms/new-console-template for more information
using LateBingingUsingReflection;
using System.Reflection;

Console.WriteLine("<<<<<<<<<<<<<<Early Binding>>>>>>>>>>>>>>>");

Person p3 = new Person();

string fullName = p3.GetFullName("Hasanur", "Rashid");
Console.WriteLine($"Full Name is {fullName}");


Console.WriteLine("<<<<<<<<<<<<<<Late Binding>>>>>>>>>>>>>>>");

Assembly exetuableAssembly = Assembly.GetExecutingAssembly();
Type personType = exetuableAssembly.GetType("LateBingingUsingReflection.Person");
 object personInstance = Activator.CreateInstance(personType);
MethodInfo getFullNameMethod = personType.GetMethod("GetFullName");


string[] parameters = new string[2];
parameters[0] = "Alhamdu";
parameters[1] = "Lillah";
string name =  (string) getFullNameMethod.Invoke(personInstance, parameters);
Console.WriteLine("Full Name ={0}", name);



