﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //array of array
    internal class Class46
    {
        static void Main()
        {
            int[][] arr = new int[3][];
            arr[0]=new int[2] { 4,6};
            arr[1] = new int[4] { 6,1,2,9};
            arr[2] = new int[1] { 5};
            //arr[3] = new int[5] { 5,2,7,1,9};

            for(int i=0;i<arr.Length;i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.Write("{0}\t", arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
