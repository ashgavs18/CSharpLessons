using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LessonA.Dayfive
{
    internal class DOtask
    {
        public static void Dotask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);

        }
        public static void DotaskA(ref int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        
    }
}
