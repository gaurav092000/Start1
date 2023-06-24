using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class31
    {
        //two dimension array
        static void Main()
        {
            int[,] arr = { { 10,20,30},{ 20,30,40},{ 30,40,50} };
            for(int i=0;i<=2;i++)
            {
                for(int j=0;j<=2;j++)
                {
                    Console.Write(" "+arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
