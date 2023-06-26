using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //recursion 
    internal class Class42
    {
        static void Test(int a,int b)
        {
            if(b<=10)
            {
                Console.Write((a * b) + "\t");
                b++;
                Test(a,b);

            }
            else if(a<10)
            {
                b = 1;
                a++;
                Console.WriteLine();
                Test(a,b);
            }
        }
        static void Main()
        {
            Test(1,1);
            Console.ReadKey();
        }
    }
}
