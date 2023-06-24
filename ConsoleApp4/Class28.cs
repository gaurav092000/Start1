using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class28
    {
        static void Main()
        {
            //copying of array
            int[] arr = { 1, 2, 3, 4 ,67,78};
            int[] arr2= new int[6];
            int i;
            Console.WriteLine("Element of arr");
            for ( i=0;i<arr.Length;i++)
            {
               
                Console.WriteLine(arr[i] + " ");
            }
            for( i=0;i<arr.Length;i++)
            {
                arr2[i] = arr[i];
            }
            Console.WriteLine("Elelment of second arr");
            for (i=0;i<arr2.Length;i++)
            {
                
                Console.WriteLine(arr2[i] + " ");
            
            }
            Console.ReadKey();

        }
    }
}
