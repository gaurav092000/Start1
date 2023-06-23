using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class11
    {
        static void Main()
        {
            int n;
            char ch;
            do {
                Console.WriteLine("Entre the number");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine("NO.  is postive");
                }
                else if (n < 0)
                {
                    Console.WriteLine("Negative no");
                }
                else
                {
                    Console.WriteLine("zero");
                }
                Console.WriteLine("do you continue(Y/N)");
                ch=char.Parse(Console.ReadLine());  
            } while (ch=='Y'|| ch=='y');
            Console.ReadKey();
        }
    }
}
