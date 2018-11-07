using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.solutions
{
    static class _10001stPrime
    {
        /*The Problem:
         * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         * What is the 10 001st prime number?
         */
        public static long solve_10001stPrime()
        {
            int numOfPrimesFound = 6;
            long naturalNumber = 13L;
                   
            while(numOfPrimesFound < 10002)
            {
                naturalNumber++;
                if (isPrime(naturalNumber))
                {
                    numOfPrimesFound++;
                    if(numOfPrimesFound == 10001)
                    {
                        break;
                    }
                }
            }
            return naturalNumber;

        }
        static bool isPrime(long numToCheck)
        {
            int num = 0;
            for (int i = 1; i <= numToCheck; i++){
                if(numToCheck % i == 0)
                {
                    num++;
                }                
            }
            if (num == 2)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
