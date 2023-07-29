// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.Collections.Specialized;

List<string> listStrings = new List<string>();
listStrings.Add("Hasan");
listStrings.Add("Mamun");
listStrings.Add("Hasan");

Console.WriteLine("List Item");
Console.WriteLine();
foreach (var item in listStrings)
{
    Console.WriteLine(item);
}


ArrayList arrayList= new ArrayList();
arrayList.Add("HTML");
arrayList.Add("CSS");
arrayList.Add("C#");
Console.WriteLine();
Console.WriteLine("Array List");
Console.WriteLine();
foreach (var item in arrayList)
    Console.WriteLine(item);



HashSet<string> hasSet = new HashSet<string>();
hasSet.Add("HTML");
hasSet.Add("CSS");
hasSet.Add("HTML");
hasSet.Add(".NetCore");

Console.WriteLine();
Console.WriteLine("Has set contains only unique value");
Console.WriteLine();
foreach (var item in hasSet)
    Console.WriteLine(item);

Hashtable hashtable = new Hashtable();
hashtable.Add("A",1);
hashtable.Add("B",2);
hashtable.Add("C",3);
hashtable.Add(20,4);

Console.WriteLine();
Console.WriteLine("Has Table Non generic Type of has set");
Console.WriteLine();
foreach (var item in hashtable)
    Console.WriteLine(item);

Dictionary<string, int> dictionary= new Dictionary<string, int>();

dictionary.Add("D", 1);
dictionary.Add("E", 2);
dictionary.Add("F", 3);

Console.WriteLine();
Console.WriteLine("Dictionary");
Console.WriteLine();
foreach (var item in dictionary)
    Console.WriteLine(item);

