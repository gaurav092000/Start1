using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        string FirstName, LastName;

        public void Set(string FirstName,string LastName)
        {
            this.FirstName = FirstName;
                this.LastName = LastName;
        }
        public string get()
        {
            return FirstName +" "+ LastName;
        }
    }

    internal class Class38
    {
        static void Main()
        {
            Student st = new Student();
            st.Set("Gaurav","Kawde");
            Console.WriteLine(st.get());
            Console.ReadKey();
        }
    }
}
