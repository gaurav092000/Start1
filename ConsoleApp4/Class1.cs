using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        //voting program
        static void Main()
        {
            int n;
            char ch;
            do
            {
                Console.WriteLine("Enter the age of voting");
                n = int.Parse(Console.ReadLine());
                if (n > 18)
                {
                    Console.WriteLine("Your are eligible");
                }
                else
                {
                    Console.WriteLine("Your not eligible");
                }
                Console.WriteLine("DO you want to continue(Y/n)");
                ch=char.Parse(Console.ReadLine());
                Console.ReadKey();
            } while (ch == 'y' || ch == 'Y');
            Console.ReadKey();
        }
    }
}
