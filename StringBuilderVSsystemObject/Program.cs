// See https://aka.ms/new-console-template for more information


using System.Text;

string s = "I";
s+= " am";
s += " Hasan";
Console.WriteLine(s);

StringBuilder sb = new StringBuilder("I");
sb.Append(" am");
sb.Append(" Hasan.");
Console.WriteLine(sb.ToString());


string s2 = string.Empty;
for(int i = 0;i<10;i++)
{
    s2 += i.ToString() + " ";
}
Console.Write(s2);
Console.WriteLine();

StringBuilder sb2 = new StringBuilder();
for (int i = 0; i < 10; i++)
{
    sb2.Append(i.ToString() + " ");
}
Console.Write(sb2.ToString());
