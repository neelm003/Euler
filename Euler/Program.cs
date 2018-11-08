using Euler.solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            //Euler #5
            //Console.WriteLine("The Answer to the SmallestMultiple Euler problem: " + SmallestMultiple.solveSmallestMultiple());
            //Euler #6
            //Console.WriteLine("The Answer to the Sum Square Difference Euler problem: " + SumSquareDifference.solveSumSquareDifference());
            //Euler #7
            //Console.WriteLine("The Answer to the 10001st Prime Euler problem: " + _10001stPrime.solve_10001stPrime());
            //Euler #8
            //Console.WriteLine("The Answer to the Largest Product in Series Euler problem: " + LargestProductinSeries.solveLergestProductinSeries());
            int[] arr = { 21, 39, 63, 99, 105 };
            GCD  gcd = new GCD();
            Console.WriteLine(" the answer: " + gcd.findGCD(5, arr));

            int[] state = { 1, 0, 1, 1, 0, 1, 0, 0};
            houses houseState = new houses();
            int[] answerArr =  houseState.housesSolution(6, state);
            Console.Write(" the answer: ");
            for (int i = 0; i < answerArr.Length; i++)
            {
                Console.Write(answerArr[i]);
            }
            Console.Write(" \n");


            DateTime end = DateTime.Now;
            Console.WriteLine("Start Time: " + start);
            Console.WriteLine("End Time  : " + end);
            Console.WriteLine("Run Time  : " + (end - start));

            if((end-start).Minutes > 1 )
            {
                Console.WriteLine("Your total run time was greater than one minture. You should try to optimize your solution");
            }
            else{
                Console.WriteLine("Congratulations: Your total run time was less than one minture. Can you make irun fatser?");
            }
            Console.ReadLine();
        }

        static bool isPalindrome(string productString)
        {
            char[] charArray = productString.ToCharArray();
            Array.Reverse(charArray);
            string reverseProductString = new string(charArray);
            return productString.Equals(reverseProductString);
        }

    }
}
