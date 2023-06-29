using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class66
    {
        static void Main()
        {
            
            var b=new List<string>();
            b.Add("Gaurav");
            b.Add("ramesh");
            b.Add("Suresh");
            b.AddRange(new string[2] {"hello","sa"});
    
            foreach (var name in b)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("index :"+ b.IndexOf("Suresh"));
            Console.WriteLine("count :"+b.Count());
            Console.ReadKey();

             
           // var b= new List<string>();
        }
    }
}
