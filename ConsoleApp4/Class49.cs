using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Test
    {
        public void Printff(int i)
        {
            Console.WriteLine(i);
        }
        public void Printff(char i)
        {
            Console.WriteLine(i);
        }
        public void Printff(float i)
        {
            Console.WriteLine(i);
        }
        public void Printff(double i)
        {
            Console.WriteLine(i);
        }
    }
    internal class Class49
    {
        //polymorphism

       static void Main()
        {
            Test test = new Test();
            test.Printff(12.2);
            Console.ReadKey();

        }
    }
}
