using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class17
    {
        static void Main()
        {
            int n, fact=1;
            int i = 1;
            Console.WriteLine("Enter the number");
            n=int.Parse(Console.ReadLine());
            while (i<=n)
            {
                fact = fact * i;
                i++;


            }
            Console.WriteLine("Fcatorial :" +fact);
            Console.ReadKey();
        }
    }
}
