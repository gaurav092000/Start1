using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class8
    {
        static void Main()
        {
            for (int i = 1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
          
        }
    }
}
