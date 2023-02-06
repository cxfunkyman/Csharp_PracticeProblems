using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *
* A prime number whose reversal is also a prime is called Emirp. 
* For example: 101, 131, 1933 are Emirps. Write a program that 
* outputs the first 100 Emirps starting from number 100. Your 
* program must contain a method to find the prime number and 
* another method for reversing a number.
 * Sample output:
 * 101 is an EMIRP.
 * 107 is an EMIRP.
 * 113 is an EMIRP.
 * 131 is an EMIRP.
 * 149 is an EMIRP.
 * 151 is an EMIRP.
 * 157 is an EMIRP.
 * 167 is an EMIRP.
 * 179 is an EMIRP.
 * 181 is an EMIRP.
 * 191 is an EMIRP.
 * 199 is an EMIRP.
 * 311 is an EMIRP.
 * .
 * .
 * .
 * 1847 is an EMIRP.
 * 1867 is an EMIRP.
 * 1879 is an EMIRP.
 * 1901 is an EMIRP.
 * 1913 is an EMIRP.
 * 1933 is an EMIRP
*/

namespace PracticeProblems
{
    internal class EMIRPnumber
    {
        //Check if the value is a prime number
        public static bool PrimeNumber(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        //Check if the prime number is a EMIRP number
        public static int EMIRPnumberCheck(int number)
        {
            int temp = 0;

            while(number != 0)
            {
                temp = temp * 10 + number % 10;
                number = number / 10;
            }
            return temp;
        }
    }
}
