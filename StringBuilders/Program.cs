// See https://aka.ms/new-console-template for more information


using Structures;
using System.Text;

Type t = Type.GetType("Structures.Test");

Console.WriteLine($"Name:{t.Name} Full Name: {t.FullName} NameSpace: {t.Namespace}");

//Test.Calculator(10,20); // here we can't declare object reference for being static type;
//Test test = new Test();
//test.CalculatorNonStatic(10, 20); // here we should declare object reference for being non static
//StringBuilder sb = new StringBuilder();

//sb.Append("Hasanf").AppendLine().Replace('s', 'H');




//Console.WriteLine(sb.ToString());
