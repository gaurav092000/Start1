using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class addition
    {
        int a, b = 20, c = 10;

        public void add()
        {
            a = b + c;
            Console.WriteLine("add :"+a);
        }
        public void sub()
        {
            a = b - c;
            Console.WriteLine("sub :"+a);
        }
        public void mul()
        {
            a = b * c;
            Console.WriteLine("mult:"+a);
        }
        public void div()
        {
            a = b / c;
            Console.WriteLine("div:"+a);
        }
        public void mod()
        {
            a = a % c;
            Console.WriteLine("mod :"+a);
        }
    }

    internal class Class24
    {
        static void Main()
        {
            addition ad = new addition();
            ad.add();
            ad.sub();
            ad.mul();
            ad.div();
            ad.mod();
            Console.ReadKey();
        }
    }
}
