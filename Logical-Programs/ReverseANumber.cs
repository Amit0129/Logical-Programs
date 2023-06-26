using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class ReverseANumber
    {
        public void ReverseAN0()
        {
            Console.WriteLine("Enter a number to reverse it");
            int givenNo = Convert.ToInt32(Console.ReadLine());
            int revNo = 0;
            int temp = givenNo;
            while (temp > 0)
            {
                int rem = temp % 10;
                revNo = (revNo * 10) + rem;
                temp /= 10;
            }
            Console.WriteLine($"The Reverse of {givenNo} is {revNo}");
        }
    }
}
