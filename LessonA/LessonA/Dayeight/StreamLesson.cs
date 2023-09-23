using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayeight
{
    internal class StreamLesson
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("press any key to enter");
            int x= Console.Read();
            ch = (char)x;
            Console.WriteLine("\n" +x+"your key is"+ch);
        }
        public static void TestTwo()
        {
            char ch = ' ';
            Console.WriteLine("press a key q to exit");
            while (ch !='q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("your key is:"+ ch);
            }

        }
        public static void TestThree()
        {
            Console.Out.WriteLine("enter a senetnce");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(" "+ str);
        }
        public static void TestNullableTypes()
        {
            int? x = 10;
           x = null;
            if(x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
                Console.WriteLine(x.GetValueOrDefault());

        }
    }
}
