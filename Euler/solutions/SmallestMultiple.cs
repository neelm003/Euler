using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.solutions
{
    static class SmallestMultiple
    {
        /* The Problem:
         * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */
        public static long solveSmallestMultiple()
        {
            long answer = 0L;
            bool contLoop = true;
            long num = 2520L;
            bool allPass = false;
            while (contLoop)
            {
                allPass = true;
                for (int i = 20; i > 1; i--)
                {
                    if (num % i == 0)
                    {

                        if (i == 2 && allPass)
                        {
                            answer = num;
                            contLoop = false;
                            break;
                        }
                    }
                    else
                    {
                        allPass = false;
                    }
                }
                num += 2;
            }

            return answer;
        }
    }
}
