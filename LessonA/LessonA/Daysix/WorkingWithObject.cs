using Asample.DayFive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daysix
{
    internal class WorkingWithObject
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001; empOne.Name = "Sam";
            Emp empTwo = new Emp();
            empTwo.ID = 1002; empTwo.Name = "Sam";
            Emp empThree = new Emp();
            empThree.ID = 1003; empThree.Name = "Sam";
            bool flag =(empOne.Equals( empTwo ));
            Console.WriteLine(flag);
            flag =(empOne.Equals( empThree ));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());


        }
        public static void TestThree()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001; empOne.Name = "Sam";
            Emp empTwo = empOne;
            empTwo.ID = 1002; empTwo.Name = "Sam";
            Emp empThree = empOne;
            empThree.ID = 1003; empThree.Name = "Sam";
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag = (empOne.Equals(empThree));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());


        }
    }
}
