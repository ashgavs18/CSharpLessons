using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Daythree
{
    internal abstract class Book
    {
        // abstract method should be in abstract class
        public Book() {
            Console.WriteLine("Book Constructor");

        }
        public abstract void OpenBook();
    }
}
