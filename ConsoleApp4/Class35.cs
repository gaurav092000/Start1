using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class35
    {
        static void Main()
        {
            int[] a = { 34, 56, 21, 45, 23 };
            Array.Sort(a);
            foreach (int n in a)
            {
                Console.WriteLine(n);
                
            }
            Console.ReadKey();
        }
    }
}
