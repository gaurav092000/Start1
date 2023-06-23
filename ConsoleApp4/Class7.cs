using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class7
    {
        static void Main()
        {
            int n;
            char ch;
            do
            {
                Console.WriteLine("Enter the number");

                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Do you want to ciontinue");
                ch=char.Parse(Console.ReadLine());  
            } while (ch=='Y' || ch=='y');
            Console.ReadKey();
        }
    }
}
