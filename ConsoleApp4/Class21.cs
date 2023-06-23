using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{


    public class Geeks
    {

        // field variable
        public int a, b;

        // member function or method
        public void display()
        {
            Console.WriteLine("Class & Objects in C#");
      }
    }

    internal class Class21
    {
        static void main()
        {
            Geeks geeks = new Geeks();
            geeks.display();
        }
    }
}
