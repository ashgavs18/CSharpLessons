using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daytwo
{
    internal class Homework
    {
        public int PatientId { get; set; }
        public int WardNo { get; set; }
        public string PatientName { get; set; } = string.Empty;
        
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string TypeofWard { get; set; } = string.Empty;
        public DateTime Time { get; set; }

        public long Phone { get; set; }
        public override string ToString()
        {
            return $"ID: {this.PatientId},Patient Name: {Title} {PatientName}, " + $"Address:{Address},Ward Number:{WardNo}, Type of Ward:{TypeofWard},\n" + $" Phone:{Phone}, Entry:{Time}";
        }
    }
    internal class Ward
    {
        public static void Patient()
        {
            Homework firstPerson = new Homework();
            firstPerson.PatientId = 1;
            firstPerson.PatientName = "ashfaq";

            firstPerson.Address = "Arumbakkam";
            firstPerson.TypeofWard = "ICU";
            firstPerson.WardNo = 101;
            firstPerson.Phone = 9789826018;
            firstPerson.Time = DateTime.Now;

            firstPerson.Title = "Mr";
            String value = firstPerson.ToString();
            Console.WriteLine(value);
        }

    }
}
