using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    struct  book

    {
        public int id;
        public string name;
        public double price;
    }
    internal class Class44
    {
        static void Main()
        {
            book b;
            b.id = 1;
            b.name = "test";
            b.price = 100;
            Console.WriteLine("id :{0} \nname : {1}\n price: {2}",b.id,b.name,b.price);
            Console.ReadKey();
        }
    }
}
