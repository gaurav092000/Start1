using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class65
    {
        static void Main()
        {

            //string example
            string name = "GAURAV";
            string str="HEllo " + name;
            Console.WriteLine(str);

            //string Builder
            StringBuilder sb = new StringBuilder();
            sb.Append("HELLO ");
            sb.Append(name);
            Console.WriteLine(sb);
        

            //string interpolation
       
            string sr = $"Hello,{name}";
            Console.WriteLine(sr);
            //string a=sr.ToString();
           // sr = Console.ReadLine($"My name is {str1} {name}");
                Console.ReadKey();
        }
    }
}
