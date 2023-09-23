using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayone
{
    internal class WorkFromHome
    {
        static void Imp()
        {
            Car car=new Car();
            Bike bike=new Bike();
            Boat boat=new Boat();
            //Vehicle v=new Vehicle();
            Console.ReadKey();
        }
    }
   abstract class Vehicle
    {
        int speed = 0;
        public abstract void Go();
           
    } 
    class Car : Vehicle
    {
        int speed = 100;
        int wheels = 4;
        public override void Go()
        {
            Console.WriteLine("The car is moving ");
        }
    }
    class Bike : Vehicle
    {
        int speed = 200;
        int wheels = 2;
        public override void Go()
        {
            Console.WriteLine("The bike is moving ");
        }
    }
    class Boat : Vehicle
    {
        int speed = 300;
        int wheels = 0;
        public override void Go()
        {
            Console.WriteLine("The boat is moving ");
        }
    }
}
