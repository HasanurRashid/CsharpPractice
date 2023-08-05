using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public class SampleOne
    {
        public delegate void Sample_1();

        public static void Method_1()
        {
            Console.WriteLine("Method_1 Invocked");
        }
        public static void Method_2()
        {
            Console.WriteLine("Method_2 Invocked");
        }
        public static void Method_3()
        {
            Console.WriteLine("Method_3 Invocked");
        }

       
    }

    public class SampleTwo
    {
        public delegate void Sample_2();

        public static void Method1()
        {
            Console.WriteLine("Method_1 Invocked");
        }
        public static void Method2()
        {
            Console.WriteLine("Method_2 Invocked");
        }
        public static void Method3()
        {
            Console.WriteLine("Method_3 Invocked");
        }
    }

    public class SampleThree
    {
        public delegate int  Sample_3();
        public static int MethodReturn_1()
        {
            return 1;
        }
        public static int MethodReturn_2()
        {
            return 2;
        }
    }
}
