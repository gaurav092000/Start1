﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class62
    {
        static void Main()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push("LAST ELEMENT");
            foreach (var x in s)
            {
                Console.WriteLine(x);

            }

            Console.WriteLine("Peek Element"+s.Peek());
            Console.WriteLine("pop element",s.Pop());
        
            Console.WriteLine("after pop", s.Peek());
            Console.ReadKey();
        }
    }
}
