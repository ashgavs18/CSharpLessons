using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daytwo
{
    internal class Box
    {
        public static int height;
        public  int width;
        public const string type = "glass";
        public int GetHeight()
        { return height; }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Box.height = 100;
            Box firstBox= new Box();
            Box secondBox= new Box();
            firstBox.width = 300;
            secondBox.width = 400;
            Console.WriteLine($"First Box={firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"Second Box= {secondBox.width}");
            Console.WriteLine(Box.type);


        }
    }
}
