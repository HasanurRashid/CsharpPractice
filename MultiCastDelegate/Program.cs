// See https://aka.ms/new-console-template for more information

using MultiCastDelegate;
using static MultiCastDelegate.SampleOne;
using static MultiCastDelegate.SampleThree;
using static MultiCastDelegate.SampleTwo;

Sample_1 del1, del2, del3, del4;

del1 = new Sample_1(Method_1);
del2 = new Sample_1(Method_2);
del3 = new Sample_1(Method_3);

del4 = del1 + del2 + del3 - del1;

del4();

Sample_2 sample_2 = new Sample_2(Method1);
sample_2 += new Sample_2(Method2);
sample_2 += new Sample_2(Method3);
sample_2 -= new Sample_2(Method1);

sample_2();

Sample_3 Sam1, sam2,sam3;

Sam1 = new Sample_3(MethodReturn_1);
sam2 = new Sample_3(MethodReturn_2);

sam3 = Sam1 + sam2;

int delReturnedValue = sam3();

Console.WriteLine($"{delReturnedValue}");

