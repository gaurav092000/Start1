using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //method overrinding
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    class Animal2 : Animal 
    {
        public override void eat() 
        {
            Console.WriteLine("eating biskit");
        }
    }
    internal class Class58
    {
        static void Main()
        {
            Animal2 a=new Animal2();
            {
                a.eat();
                Console.ReadKey();
            }
        }
    }
}
