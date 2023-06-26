using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class PrimeNumber
    {
        public void GetPrimeNumber()
        {
            Console.WriteLine("Enter a number to find if Prime Number or NOT");
            int givenNo = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (givenNo < 2)
            {
                Console.WriteLine($"The number {givenNo} is NOI Prime Number");
            }
            else if (givenNo == 2)
            {
                Console.WriteLine($"The number {givenNo} is a Prime Number");

            }
            else 
            {
                for (int i = 1; i <= givenNo; i++)
                {
                    if (givenNo % i ==0)
                    {
                        result++;
                    }
                }
                if (result == 2)
                {
                    Console.WriteLine($"The number {givenNo} is a Prime Number");
                }
                else
                {
                    Console.WriteLine($"The number {givenNo} is NOI Prime Number");
                }
            }
            
        }
    }
}
