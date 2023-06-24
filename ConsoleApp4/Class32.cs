using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class32
    {
        static void Main()
        {
            int[,] arr = new int[3,3];

            Console.WriteLine("Enter the 9 element");
            for(int i=0;i<=2;i++)
            {
                for(int j=0;j<=2;j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }

            }
            for(int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(" "+arr[i, j]);
                }
Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
