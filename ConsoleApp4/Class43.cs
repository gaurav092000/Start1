using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class43
    {
        static void Tst(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;

                }
            }
            if (count == 2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not are prime number");
            }
        }
        static void Main()
        {
            int n;
            n=int.Parse(Console.ReadLine());
           Tst(n);
            Console.ReadKey();
        }
    }
}
