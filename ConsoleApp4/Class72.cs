using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface Aa
    {
        void add();
    }
    interface Bb
    {
        void sub();
    }

    internal class Class72
    {
        public void add(int a,int b) 
        {
            int c = a + b;
            Console.WriteLine("Add :"+c);
        }
        public void sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Sub :"+c);
        }
        static void Main()
        {
            Class72 c= new Class72();
            c .add(1,2);
            c.sub(1,2);
            Console.ReadKey();
            
        }
    }
}
