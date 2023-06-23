using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class12
    {
        static void Main()
        {
            int n,count=0;
            Console.WriteLine("Enetr the number");
            n=int.Parse(Console.ReadLine());    
            for(int i = 1; i <=n; i++)
            {
                if(n%i == 0)
                {
                    count++;
                }
            }
            if(count== 2)
            {
                Console.WriteLine("Prime number");
            }
            else
            { Console.WriteLine("not a prime number"); }
            Console.ReadKey();
        }

    }
}
