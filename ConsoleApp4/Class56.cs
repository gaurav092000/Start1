using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class student
    {
        int id;
        string name;
        public student() 
        {
            Console.WriteLine("this is a default constructor");
        }
        public student(int id,string name) 
        {
            this.id = id;
            this.name = name;
        }
       public void show()
        {
            Console.WriteLine("id :"+id);
            Console.WriteLine("Name :" + name);
        }
    }
    internal class Class56
    {
        static void Main()
        {
            student s= new student();
            student s1= new student(1,"Gaurav");
            s1.show();
            Console.ReadKey();
        }
    }
}
