using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class13
    {

        static void Main()
        {
            //CONVERT into days into year ,month ,day
            int day;
            Console.WriteLine( "Entrer the  days");
            day=int.Parse(Console.ReadLine());

            int year, week, month;
            year = day / 365;
            Console.WriteLine("year :"+year);
            day=day % 365;

            month = day / 30;
            Console.WriteLine("MONTH :" + month);
            day = day % 30;

            week = day / 7;
            Console.WriteLine("WEEK :" + week);

            day = day % 7;
            day= day / 1;
            Console.WriteLine("DAY :" + day);
            

            Console.ReadKey();





        }
    }
}
