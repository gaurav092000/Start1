using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class41
    {
        static void Main()
        {
            int a;
           a= add(2,4);
            Console.WriteLine("add :" +a);
            Console.ReadKey();
        }
        static int add(int x,int y)
        {
            int z=x+y;
            return z;
        }
    }
}
