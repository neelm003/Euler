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
            //Euler #5
            //Console.WriteLine("The Answer to the SmallestMultiple Euler problem: " + SmallestMultiple.solveSmallestMultiple());
            //Euler #6
            //Console.WriteLine("The Answer to the Sum Square Difference Euler problem: " + SumSquareDifference.solveSumSquareDifference());
            //Euler #7
            Console.WriteLine("The Answer to the 10001st Prime Euler problem: " + _10001stPrime.solve_10001stPrime());
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
