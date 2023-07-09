// See https://aka.ms/new-console-template for more information



using Method;

int n = int.Parse(Console.ReadLine());

EvenOdd evenOdd = new EvenOdd();

int sum = evenOdd.Add(10, 20);
Console.WriteLine(sum);

EvenOdd.EvenNumber(n);

EvenOdd.EvenNumber(20);