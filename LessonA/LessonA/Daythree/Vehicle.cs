using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daythree
{
    internal abstract class Vehicle
    {
        public Vehicle() 
        {
            Console.WriteLine("vehicle constructor");
        }
         public void Start()
        {
            Console.WriteLine("vehicle started");
        }
    }
    // end of class 
    // abstract class is not mandatory to have abstract method
    // abstract class must be inherited
    internal class Car: Vehicle
    {
        public Car()
        {
            Console.WriteLine("car constructor");
        }
    }
    class VehicleTester
    {
        public static void TestOne()
        {
            Vehicle tester = new Car();
            tester.Start();
        }

    }
}

