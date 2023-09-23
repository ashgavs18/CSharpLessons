using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayone
{
    internal class ValueTypeLesson
    {
        internal static void TestValueTypes()
        {
            Console.WriteLine("Hello, World!");
            byte b1 = 0;
            Console.WriteLine(b1);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(double.MaxValue);
        }
        public static void TestMethod() // static methods it is an function , it doesnt need objects
        {
            Console.WriteLine("Test");
        }
    }
}
