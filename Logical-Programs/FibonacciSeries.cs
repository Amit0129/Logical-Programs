﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class FibonacciSeries
    {
        public void GetFibonacciSeries()
        {
            Console.WriteLine("Enter a number to find if Fobonacci Serise");
            int givenNo = Convert.ToInt32(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 2; i < givenNo; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1= n2;
                n2 = n3;
            }
        }
    }
}
