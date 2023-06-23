using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class14
    {
        static void Main()
        {
            // convert upper to lower
            char ch;
            Console.WriteLine("enter the charater");
            ch = char.Parse(Console.ReadLine());
            if(ch>=65 && ch<=90)
            {
                Console.WriteLine(Convert.ToChar(ch+32));
            }
            else
            {
                Console.WriteLine(Convert.ToChar(ch - 32));
            }
            Console.ReadKey();

        }
    }
}
