using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class63
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            stack.Push("Last Element");

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek element: " + stack.Peek());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("After Pop, Peek element: " + stack.Peek());
            Console.ReadKey();
        }
    }
}
