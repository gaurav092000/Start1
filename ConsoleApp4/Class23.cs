using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Demo
    {
        int a = 10; String sr = "Gaurav";
       public void show()
        {
            Console.WriteLine(a + " "+sr);
        }

    }
    internal class Class23
    {

       

        static void Main()
        {
            Demo demo = new Demo();
            demo.show();
            Console.ReadKey();

        }

    }
}
