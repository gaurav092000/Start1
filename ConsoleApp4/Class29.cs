using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class29
    {
        static void Main()

        {
            //addition of two array
            int  [] arr =new int[5];
            int [] arr2=new int[5];
            int [] arr3=new int[5];
            int i;
            
            for(i=0;i<=4;i++)
            {
                Console.WriteLine("Enter the first element in arr");
                arr[i]=int.Parse(Console.ReadLine());   

            }
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Enter the second element in arr");
                arr2[i] = int.Parse(Console.ReadLine());

            }
            arr3 = arr.Concat(arr2).ToArray();
            Console.WriteLine("Result Array: [{0}]" , String.Join(",",arr3));
            Console.ReadKey();
        }

    }
}
