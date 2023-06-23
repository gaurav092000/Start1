using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class9
    {
        static void Main()
        {
            //factorial
            int fact=1, n;
            Console.WriteLine("Enter the number");
            n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) 
            {
                fact = fact * i;
                
            }
            Console.Write(fact);
            Console.ReadKey();

        }
    }
}
