using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class48
    {
        static void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;

        }
        //ref parameter
        static void Main()
        {
            int x = 100, y = 200;
            swap(ref x,ref y);
            Console.WriteLine("X :{0}\n Y: {1}", x, y);
               Console.ReadKey();
        }
    }
}
