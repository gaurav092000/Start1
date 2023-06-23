using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class6
    {

        static void Main()
        {
            //loop 
            //patter
            Console.WriteLine("Enter the numbwer");
            for (int i=1;i<=5; i++)
            {
                for (int j=1;j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();  
        }
    }
}
