using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class61
    {
        static void Main()
        {
            StringBuilder str= new StringBuilder("Gaurav");
            str.Append("kawde");
           str.AppendFormat("{0:C}",25);
            StringBuilder str1 = new StringBuilder("HEllo world");
            str1.Insert (5,"C#");
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
