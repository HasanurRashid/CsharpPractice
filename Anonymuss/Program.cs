// See https://aka.ms/new-console-template for more information

dynamic person_1 = new { Name = "Hasan",Age =35.5, MobileNo = 0129999999 };

var person = new { Name = "Hasan",Age =35.5, MobileNo = 0129999999 };

Console.WriteLine("Name: {0} , Age: {1} , Mobile No: {2} ",person.Name,person.Age,person.MobileNo);

Console.WriteLine($"Name: {person.Name} , Age: {person.Age} , Mobile No: {person.MobileNo} ");
