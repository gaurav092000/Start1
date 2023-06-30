using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Mymath
    {
        protected double result;
        public  double get()
        {
          return result;        
        }
    }
    class Mymath2 : Mymath 
    {
        public void  Set(int a,int b)
        {
            result = a + b;

        }
    }
    class Mymath3 : Mymath
    {
        public void set(int a,int b)
        {
            result = a - b;
        }
    }

    internal class Class69
    {
        static void Main()
        {
            Mymath2 m1= new Mymath2();
            m1.Set(1,2);
            Mymath3 m2= new Mymath3();
            m2.set(1,2);
            Console.WriteLine( "add : "+m1.get());
            Console.WriteLine("sub : "+m2.get());
            Console.ReadKey();
        }
    }
}
