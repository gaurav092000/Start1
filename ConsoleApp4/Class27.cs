using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class27
    {
        static void Main()
        {
            int[] arr=new int[10];
            int i;
            for(i=0;i<=4;i++)
            {
                Console.WriteLine("Enter the ELemenmt");
                arr[i] =int.Parse(Console.ReadLine());  
            }
            for(i=0;i<=4;i++)
            {
                Console.WriteLine("element" + arr[i]);
            }
            Console.ReadKey();
        }
    }
}
