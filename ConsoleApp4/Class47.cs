using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class47
    {
        static void Main()
        {
            double bs;
            Salary[] sal = new Salary[3];
            for (int i = 0; i < sal.Length; i++)
            {
                sal[i] = new Salary();
                Console.WriteLine("Enter the salary");
                bs = double.Parse(Console.ReadLine());
                sal[i].set(bs);
                sal[i].cal();


            }
            for(int i=0;i<sal.Length;i++)
            {
                Console.WriteLine("Da : " + sal[i].getda());
                Console.WriteLine("Hra : " + sal[i].gethra());
                Console.WriteLine("TS : " + sal[i].getTs());
                Console.ReadKey();
            }
            
        }

    }
}
