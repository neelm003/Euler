using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.solutions
{
    static class SumSquareDifference
    {
        /*The Problem:
         * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         * What is the 10 001st prime number?
         */
        public static long solveSumSquareDifference()
        {
            long sumOfSquares = 0L;
            int sumOfNaturals = 0;
            long squareOfSum = 0L;

            for(int i = 1; i <= 100; i++)
            {
                sumOfSquares += (i * i);
                sumOfNaturals += i;
            }
            squareOfSum = sumOfNaturals * sumOfNaturals;

            return squareOfSum - sumOfSquares;
             
        }
    }
}
