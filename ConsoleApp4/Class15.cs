using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class15
    {
        static void Main()
        {
            int[] arr= {1,2,3,4,5};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array :" + arr[i]);
                if (arr[i]%2==0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            Console.ReadKey();  
        }
    }
}
