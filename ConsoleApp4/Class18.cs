using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class18
    {
        static void Main()
        {
            int [] arr = { 23, 34, 45, 67, 54 };
            foreach(var item in arr)
            {
                Console.WriteLine("print"+item);
            }
            Console.ReadKey();  
        }
    }
}
