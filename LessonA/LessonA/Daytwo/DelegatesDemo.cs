using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daytwo
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    internal class DelegatesDemo
    {
        public void AddNums(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "Hello" + name;
        }
        

    }
    public class Implementation
    {
        public static void Program()
        {


            DelegatesDemo p = new DelegatesDemo();
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(1, 2);
            SayDelegate sd = new SayDelegate(DelegatesDemo.SayHello);
            string str = sd("ashfaq");
            Console.WriteLine(str);
        }
    }
}
