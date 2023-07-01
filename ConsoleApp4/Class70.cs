using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class area
    {
        protected double result;
        public double geeet()
        {
            return result;
        }

    }
    class reactangle : area
    {
        public void set(int l,int b)
        {
            result = l * b;
        }
    }
    class circle : area
    {
        public void set(int r)
        {
            result= r * r*Math.PI;
        }
    }
    internal class Class70
    {
        static void Main()
        {
          circle c= new circle();
            c.set(1);
            reactangle r = new reactangle();
            r.set(23,5);
            Console.WriteLine(c.geeet());
            Console.WriteLine(r.geeet());
            Console.ReadKey();

        }
    }
}
