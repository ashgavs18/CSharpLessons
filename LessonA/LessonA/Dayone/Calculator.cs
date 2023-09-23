using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayone
{
    internal class Calculator
    {
        public static int Add(int a, int b)
        {
            return a+b;
        }
        public static int Subtract(int a, int b)
        {
            return a-b;
        }
        public static int Multiply(int a, int b)
        {
            return a*b;
        }
        public static int Divide(int a, int b)
        {
            return a/b;
        }
        public static void TestCalculator()
        {
            Console.WriteLine("Enter p1");
            string x = Console.ReadLine();
            Console.WriteLine("Enter p2");
            string y = Console.ReadLine();
            int a = int.Parse(x);
            int b = int.Parse(y);
            int addresult = Calculator.Multiply(a, b);
            Console.WriteLine(addresult);
            addresult = Calculator.Divide(a, b);
            Console.WriteLine(addresult);
            addresult = Calculator.Add(a, b);
            Console.WriteLine(addresult);
            addresult = Calculator.Subtract(a, b);
            Console.WriteLine(addresult);
        }
    }
}
