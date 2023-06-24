using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class33
    {
        static void Main()
        {
            //traspose the matrix

            int[,] arr = new int[3, 3] {{ 1, 2, 3 },{ 4,5,6},{ 7,8,9} };
            int[,] arr2=new int[3, 3];
            
            
            for (int i = 0; i< arr.GetLength(0); i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(" "+arr[i,j]);

                }
                Console.WriteLine();
            }
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    arr2[i, j] = arr[j, i];

                }
            }
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(" " + arr2[i,j]);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
