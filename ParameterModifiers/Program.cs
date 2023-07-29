// See https://aka.ms/new-console-template for more information


using ParameterModifiers;

TestClass testClass = new TestClass();
int output = testClass.GetSum(1,2,3,4);

int[] intArray = new int[] { 1,2,3,4,5};


Console.WriteLine(testClass.GetSum(output));

Console.WriteLine(testClass.GetSum(intArray));

