using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class3
    {
        static void Main()
        {
            //nested if
            int n = 6;
            if(n<5)
            {
                if(n>3)
                {
                    Console.WriteLine("Hwllo 1");
                }
                Console.WriteLine("hello2");
            }
            else
            {
                Console.WriteLine("enter wrong number");
            }
            Console.ReadKey();
        }
    }
}
