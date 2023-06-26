using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class PerfectNumber
    {
        public void getPerfectNumber() 
        {
            int result = 0;
            Console.WriteLine("Enter a number to find if Perfect Number or NOT");
            int givenNo = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < givenNo; i++)
            {
                if (givenNo % i == 0)
                {
                    result += i;
                }
            }
            if (result == givenNo)
            {
                Console.WriteLine($"The number {givenNo} is a Perfect Number");
            }
            else
            {
                Console.WriteLine($"The number {givenNo} is NOT a Perfect Number");

            }
        }
       
    }
}
