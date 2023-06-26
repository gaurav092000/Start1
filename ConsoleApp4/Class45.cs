using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Salary
    {
        double bs, da, hra, ts;
        public void set(double b)
        {
            bs = b;
        }
        public void cal()
        {
            da = bs * 0.5;
            hra = bs * 0.15;
            ts = bs + da + hra;

        }
        public double getda()
        {
            return da;
        }
        public double gethra()
        {
            return hra;
        }
        public double getTs()
        {
            return ts;
        }
    }
    internal class Class45
    {
        static void Main()
        {
            Salary s = new Salary();
            s.set(12000);
            s.cal();
            Console.WriteLine("Da : "+s.getda());
            Console.WriteLine("Hra : " + s.gethra());
            Console.WriteLine("TS : " + s.getTs());
            Console.ReadKey();
        }
    }
}
