using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daytwo
{
    internal class Age
    {
        static int NowageDays;
        static int BdyDays;
        static int Nowagemonth;
        static int Bdymonth;
        static int Nowageyear;
        static int Bdyyear;
        static int noofDays;
        static int noofmonth;
        static int noofyear;

        public static void AgeofAPerson()
        {

            // Prompt the user for their date of birth
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = String.Empty;

            dobString = Console.ReadLine();
            //if (dobString == null)
            //{
            //    Console.WriteLine("Date Of Birth is NULL!!!");
            //    return;
            //}
            // Parse the date of birth
            DateTime dob = DateTime.Parse(dobString);
            Console.WriteLine(dob);
            DateTime now = DateTime.Now;
            NowageDays = now.Day;
            BdyDays = dob.Day;
            Nowagemonth = now.Month;
            Bdymonth = dob.Month;
            Nowageyear = now.Year;
            Bdyyear = dob.Year;
        }
            public static int Days()
            {
                if (NowageDays > BdyDays)
                {
                     noofDays = NowageDays - BdyDays;
                    return noofDays;

                }
                else
                {
                    Nowagemonth--;
                    NowageDays += 30;
                     noofDays = NowageDays - BdyDays;
                    return (noofDays);
                    Console.WriteLine(noofDays);

                }
            }
            public static int Month()
            {
                if (Nowagemonth > Bdymonth)
                {
                     noofmonth = Nowagemonth - Bdymonth;
                    return (noofmonth);
                    Console.WriteLine(noofmonth);
                }
                else
                {
                    Nowageyear--;
                    Nowagemonth += 12;
                     noofmonth = Nowagemonth - Bdymonth;
                    return (noofmonth);
                    Console.WriteLine(noofmonth);
                }
            }
            public static int Year()
            {
                if (Nowageyear > Bdyyear)
                {
                     noofyear = Nowageyear - Bdyyear;
                    return (noofyear);
                   
                }
            return 0;
            }
          






        
    }
    public class Imp
    {
        public static void Program()
        {
            Age.AgeofAPerson();
            int noofdays = Age.Days();
            int noofmonth = Age.Month();
            int noofyear = Age.Year();
            Console.WriteLine(noofdays);
            Console.WriteLine(noofmonth);
                
            Console.WriteLine(noofyear);
        }
    }
}
   


