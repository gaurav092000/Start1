using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Rectangle

    {
        int area;
        public Rectangle (int l,int b)
        {
            area = l * b;

        }
       public void show()
        {
            Console.WriteLine("area :"+area);
        }
    }
    internal class Class52
    {
        static void Main()
        {
            Rectangle r = new Rectangle(3, 4);
            r.show();
            Rectangle r1 = r;
            r1.show();
            Console.ReadKey();
        }
    }
}
