using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class shape
    {
        public double area;
        public double getarea
            
        {
            get {

            return area;   
            }
            
        }
        

    }
    class Circle : shape
    {
        public void set(int r)
        {
            area = r * r * Math.PI;
        }
    }
    internal class In2
    {
        static void Main()
        {
            Circle c=new Circle();
            c.set(2);
            Console.WriteLine(c.getarea);
            Console.ReadKey ();
        }
    }
}
