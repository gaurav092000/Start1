using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class55
    {
        //wap of method overloading

        class Employees
        {
            string name;
            double salary;
            public Employees(string newName)
            {
                name= newName;
            }
            public  Employees(double newsalary)
            {
                salary=newsalary;
            }
            public string get()
            {
                return name;
            }
            public double getSalary() 
            {
                return salary;
            }
        }
        static void Main()
        {
            Employees e=new Employees("Gaurav Kawde");
            Console.WriteLine(e.get());
            double n = 123213;
            Employees e1 = new Employees(n);
            Console.WriteLine(e1.getSalary());
            Console.ReadKey();

        }

    }
}
