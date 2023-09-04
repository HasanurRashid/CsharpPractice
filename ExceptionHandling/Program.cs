// See https://aka.ms/new-console-template for more information

StreamReader streamReader = new StreamReader(@"E:\Hasan\DevSkill\FileRead.txt");
Console.WriteLine(streamReader.ReadToEnd());
streamReader.Close();