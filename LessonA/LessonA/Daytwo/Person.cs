using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daytwo
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;   
        public string LastName { get; set; } = string.Empty;    
        public string Title { get; set; }= string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; }=string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}, Name: {Title} {FirstName} {LastName}, " + $"Address:{Address},City:{City}, State:{Region},\n" + $" Phone:{Phone}, Country:{Country}, Zip:{PostalCode}";
        }

    }
    internal class TestPerson
    {
        public static void TestOne()
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "ashfaq";
            firstPerson.LastName = "A";
            firstPerson.Address = "Arumbakkam";
            firstPerson.City = "Chennai";
            firstPerson.Country = "India";
            firstPerson.Phone = 9789826018;
            firstPerson.PostalCode = "6000 94";
            firstPerson.Region = "Asian";
            firstPerson.Title = "Mr";
            String value = firstPerson.ToString();
            Console.WriteLine(value);
        }

    }
}
