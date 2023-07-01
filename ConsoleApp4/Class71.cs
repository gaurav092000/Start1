using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class A
    {
         protected int a, b, c;
        public void Add(int a,int b)
        {
            c = a + b;
            Console.WriteLine("ADDition :"+ c);
        }
        public void Sub(int a, int b)
        {
            c = a - b;
            Console.WriteLine("Sub :" + c);
        }
    }
    class B :A
    {
        public void Mult(int a, int b)
        {
            c = a*b;
            Console.WriteLine("Mult :" + c);
        }
        public void Div(int a, int b)
        {
            c = a / b;
            Console.WriteLine("Division :" + c);
        }
    }
    internal class Class71
    {
        static void Main()
        {
            B b = new B();
          
            b.Add(2,4);
            b.Sub(2,4);
            b.Mult(2,4);
            b.Div(2,4);
            Console.ReadKey();
        }
    }
}
