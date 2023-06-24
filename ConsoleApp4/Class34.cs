using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class34
    {
        static void Main()
        {
            //sqrt

            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            double root = 1;
            int i = 0;
        
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1)
                {
                    break;
                }
            }
            Console.WriteLine("root :"+root);
            Console.ReadKey();
        }
    }
}
