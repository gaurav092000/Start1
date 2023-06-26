using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //string 

    internal class Class39
    {
        static void Main()
        {
            string data = "Gaurv kawde";
            int s = data.Length;
            int a=data.LastIndexOf('v');
            string first = "gaurav";
            string second = "Mahesh";
            string name=string.Concat(first, second);
            Console.WriteLine(name);
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
