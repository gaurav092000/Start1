using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class2
    {
        //according to percentage
        //if else ladder
        static void Main()
        {
            int per;
            Console.WriteLine("Enter the  percentage");
            per = int.Parse(Console.ReadLine());
            if (per >= 80)
            {
                Console.WriteLine(" REsult is pAss");
            }
            else if(per<80 && per>60)
            {
                Console.WriteLine(" Seccondd Div");

            }
            else if (per<60 && per>35)
            {
                Console.WriteLine("Third division");

            }
            else
            {
                Console.WriteLine("Fail");
                    }
            Console.ReadKey();
        }
    }
}
