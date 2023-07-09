// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        int i = 10;
        SampleMethod(ref i);
        Console.WriteLine(i);

        int sum = 0;
        int product = 0;
        decimal divide = (decimal)0.00;
        OutParameter(20, 4, out sum, out product, out divide);

        Console.WriteLine("Sum : {0}, Product : {1}, Divident : {2}",sum,product,divide);

        Console.WriteLine($"Sum : {sum}, Product : {product}, Divident: {divide}");

        int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ArrayParameter(inputArray);
        Console.WriteLine();
        ArrayParameter(2,4,6,8,10);
    }

    public static void SampleMethod(ref int j)
    {
        j = 101;
    }

    public static void OutParameter(int first, int last,out int sum, out int product,out decimal divident)
    {
        sum = first  + last;
        product = first * last;
        divident = first / last;
    }

    public static void ArrayParameter(params int[] numbersArray)
    {
        Console.WriteLine("Total {0} Elements in the parameter Array.", numbersArray.Length);
        foreach(var number in numbersArray)
        {
            Console.Write(number + " ");
        }
    }
}
