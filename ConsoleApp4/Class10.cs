using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class10
    {
        static void Main()
        {
            //sum of all natural number
            int sum = 0, n;
            Console.WriteLine("Enter the number ");
           n=int.Parse(Console.ReadLine()); 
            for(int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum :" + sum);
            Console.ReadKey();

        }
    }
}
