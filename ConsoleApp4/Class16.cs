using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class16
    {
        static void Main()
        {
            int n,count=0;
            n=int.Parse(Console.ReadLine());
            while(n!=0) 
            {
                count++;
                n = n / 10;
            
            }
            Console.WriteLine(count);
            Console.ReadKey();  
        }
    }
}
