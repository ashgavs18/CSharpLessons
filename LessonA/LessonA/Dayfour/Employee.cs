using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayfour
{
    public enum City { Chennai ,Bangalore, Hyderabad, Pune}
    public enum Designation { Manager, Admin, Developer}
    internal class Employee
    {
        public readonly int Eid; // readonly variable can be assingned only through constructor
        public string Ename;
        public City Ecity;
        public Designation Jobtitle;
        public Employee (int v1) { Eid = v1;}
        public override String ToString()
        {
            String output = String.Empty;
            output = $"Details of a employee are : ID={Eid} Name={Ename} {Ecity} {Jobtitle}";
            return output;
        }
    }
    class TestEmployee
    {
        public static void TestOne()
        {
            Employee e1 = new Employee(348);
            e1.Ename = "John";
            e1.Ecity = City.Bangalore;
            e1.Jobtitle = Designation.Developer;
            String output = e1.ToString();
            Console.WriteLine(output);
        }
    }
}

