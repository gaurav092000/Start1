using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Demoo
    {
       public  Demoo(int n) 
        {
            int count = 0;
            //prime number code
            for (int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("itd is prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }
        }
    }
    internal class Class51
    {
        static void Main()
        {

            //parametre construtor
            Demoo d = new Demoo(4);

            Console.ReadKey();

        }
    }
}
