using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class30
    {
        static void Main()
        {
            //addition of array

            int[] a = new int[10];
            int n,sum=0;
            Console.WriteLine("Enter the size of array");
             n= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            for(int i=0;i<n;i++)
            {
                a[i]=int.Parse(Console.ReadLine()); 
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum=" + sum);
            Console.ReadKey();


        }
    }
}
