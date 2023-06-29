using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class AA
    {
       public void  HelloA()
        {
            Console.WriteLine("Class A");
        }
    }
    class BB :AA
    {
        public void HelloB()
        {
            Console.WriteLine("Class B");
        }
    }
    internal class Class68
    {
        //inhertence
        static void Main()
        {
            BB b=new BB();
            b.HelloA();
            b.HelloB();
            
            Console.ReadKey();
        }
    }
}
