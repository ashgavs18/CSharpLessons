using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daytwo
{
    internal class DemoA
    {
       static int x = 123; // global , member, class varibale , it is an non static variable
        static int y = 567;

        public static void FirstMethod()
        {
            int y = 2000; // local variable
            Console.WriteLine(x);
            //Console.WriteLine(x);
            Console.WriteLine(DemoA.y);
        }
        public  void SecondMethod()
        {
            int y = 2000; // local variable
            Console.WriteLine(x);
            //Console.WriteLine(x);
            Console.WriteLine(DemoA.y);
        }

    }
    internal class DemoB
    {
    }
}
namespace LessonA.Gavs
{
    internal class DemoA
    {

    }
    
}
