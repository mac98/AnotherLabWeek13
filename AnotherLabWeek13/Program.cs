using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherLabWeek13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optional Parameter Tests. First test has no passed in value.");
            OptParamTest();
            OptParamTest(12);

            Console.WriteLine("Named Parameter Tests. Params are initially ordered c, a, b. First test reorders them alphabetically. Second does not.");
            NamedParamsTest(a: 3, b: 12, c: 4);
            NamedParamsTest(4,3,12);

            Console.WriteLine("Variable Number of Params Test. First test has 4 values. Second has 6.");
            VarNumOfParamsTest(1, 3, 5, 7);
            VarNumOfParamsTest(2, 20, 200, 18, 180, 47);
            Console.Read();
        }

        private static void OptParamTest(int test_num = 7)
        {
            Console.WriteLine("Optional Parameter Test: " + test_num);
        }

        private static void NamedParamsTest(int c, int a, int b)
        {
            Console.WriteLine("Named Parameter Test: " + c + a + b);
        }

        private static void VarNumOfParamsTest(params int[] numbers)
        {
            int average = 0;
            foreach (int i in numbers)
            {
                average += i;
            }
            average /= numbers.Length;
            Console.WriteLine("Variable Number of Parameters Test: " + average);
        }
    }
}
