using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    internal class Class37
    {
        static void Test(int a,int b,int c,out int tm,out double per)
        {
            tm = a + b + c;
            per = tm / 3.0;

        }
        static void Main()
        {
            int t;
            double p;
            Test(23, 75, 54,out t,out p);
             p=Math.Round(p,2);
            Console.WriteLine("T : {0}\nper : {1}",t,p);
            Console.ReadKey();
        }
    }
}
