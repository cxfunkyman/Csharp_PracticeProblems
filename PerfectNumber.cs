using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace PracticeProblems
{
    internal class PerfectNumber
    {
        public static bool PerfectNumberFirstApproach(Int64 number)
        {
            long compareNumber = 0;

            for (int i = 2; i <= number; i++)
            {
                compareNumber = (long)(Math.Pow(2, (i - 1)) * (Math.Pow(2, i) - 1)); // [2^(p−1)]*[(2^p) − 1]

                if (number == compareNumber)
                    break;
                else
                    continue;
            }
            if (number == compareNumber)
                return true;
            else
                return false;
        }
        public static bool PerfectNumberSecondApproach(Int64 number)
        {
            // Second approach, using reminder and addition to get the result.

            int sum = 1; // start with one because must be a prime number to get the resulting addition.

            for(int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                    sum += i;
                if (number == sum)
                    break;
            }
            if (number == sum)
                return true;
            else
                return false;
        }
    }
}
