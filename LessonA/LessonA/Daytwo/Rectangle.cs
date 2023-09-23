using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daytwo
{
    public delegate double RectDelegate(double width, double height);
    internal class Rectangle
    {
        public double GetArea(double width, double height)
        {
           return (width*height);
        }
        public double GetPerimeter(double width, double height)
        {
            return (2*(width+height));
        }
    }
    public class Implementation1
    {
        public static void Implementation()
        {
            Rectangle rectangle = new Rectangle();
            RectDelegate rd = new RectDelegate(rectangle.GetArea);
            rd += rectangle.GetPerimeter;
            
            double result = rd.Invoke(10.00, 10.00);
            Console.WriteLine(result);
        }
    }

}
