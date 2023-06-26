using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{

    class Book
    {
        int id;
        string name;
        double price;

        public void setter(int id,string name,double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public int getter(int id)
        {
            return id;
        }
        public double getPrice()
        {
            return price;
        }
        public string getName()
        {
            return name;
        }
            public void show()
        {
            Console.WriteLine("ID :"+ id);
            Console.WriteLine("Name :"+name);
            Console.WriteLine("price :"+price);
        }
    }
    internal class Class36
    {
      static void Main()
        {
            Book b = new Book();
            b.setter(1,"c",123);
            b.show();
            Console.ReadKey();

        }

    }
}
