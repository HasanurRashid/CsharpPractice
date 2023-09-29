// See https://aka.ms/new-console-template for more information

List<int> list = new List<int> { 0 ,10,8, 9,6,7,4,5,3,2,1};
list.Sort();

foreach (int i in list)
{
    Console.WriteLine(i);
}
