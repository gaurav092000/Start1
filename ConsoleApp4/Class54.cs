using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //check list
    //1)to demo of construtor
    //constroter overloding
    class Testt
    {
       
        public Testt(int x,int y) 
        {
            Console.WriteLine(x+y);
        }
        public Testt(double x, double y)
        {
            Console.WriteLine(x-y);
        }
        public Testt(float x, float y)
        {
            Console.WriteLine(x*y);
        }
        //public void show () 
        //{
        //    Console.WriteLine("add :" + z);
        //}
    }
    internal class Class54
    {
        static void Main()
        {
            Testt t=new Testt(3,5);
            Testt t1 = new Testt(5.33,566);
            Testt t2 = new Testt(30000, 50000);
         
            
            Console.ReadKey();

        }
    }
}
