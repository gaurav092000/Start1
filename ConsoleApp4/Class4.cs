using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class4
    {
        static void  Main()
        {
           
            //switch
            int day;
            Console.WriteLine("Enter the day ");
            day=int.Parse(Console.ReadLine());
            switch(day)
                {
                case 1:
                    Console.WriteLine("Mondya");

                    break;

                    case 2:
                    Console.WriteLine("Tuesday");
                    break;
                 
                    case 3:
                    Console.WriteLine("Wednesday");
                    break;      
                    case 4:
                    Console.WriteLine("thursday");
                    break;
                    case 5:
                    Console.WriteLine("friday");
                    break;
                    case 6:
                    Console.WriteLine("Saturday");
                    break;
                    case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    {
                        Console.WriteLine("Not  valid");
                        break;
                    }
                    

            }
            Console.ReadKey();
        }
    }
}
