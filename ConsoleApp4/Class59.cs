using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class59
    {
        static void Main()
        {
            //stopwatch
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("press enter to start the stopwatch");
          Console.ReadLine();
            stopwatch.Start();

            Console.WriteLine("press enter to stop");
            Console.ReadLine();
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.WriteLine("elapsed Time :" +elapsed);
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
