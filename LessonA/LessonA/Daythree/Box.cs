using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daythree
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;



        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");

        }
        public override string ToString()
        {
            return $"Height:{Height}, Length:{Length}, Width:{Width}";
        }
    }
    internal class WoodenBox : Box // inheritance child class : parent class
    {
        public int Area;
        public WoodenBox() : base(1) // when we use parameter parent constructor , we r doing explicitly
        {
            Console.WriteLine("Wooden BOX Constructor");

        }
        public void Move()
        {
            Console.WriteLine("wooden box shifted");
        }
        public override string ToString()
        {
            return "tom and jery";
        }
    } 
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(1);
            box.Width = 5;
            box.Height = 10;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);
           // box.Area = 1;
           // box.Move();



        }
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Width = 5;
            box.Height = 10;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area = 1;
            box.Move();

        }
        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Width = 5;
            box.Height = 10;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();// tom and jerry , it is overriiding the child class first if it is not present parent class is overriding
            Console.WriteLine(output);
            //box.Area = 1;
            //box.Move();

        }
    }
}
