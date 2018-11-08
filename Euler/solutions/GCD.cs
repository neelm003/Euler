// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
using System;
using System.Collections.Generic;

namespace Euler.solutions
{
    public class GCD
    {
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public int generalizedGCD(int num, int[] arr)
        {
            // WRITE YOUR CODE HERE
            int gcd = findSmallest(arr); //initially set to the smallest number in the array
            int[] factorsOfSmallestNum = findFactors(gcd);
            int temp = 0;
            for (int i = 0; i < num; i++)
            {
                if (!(arr[i] % gcd == 0))
                {
                    for (int j = 0; j < factorsOfSmallestNum.Length; j++)
                    {
                        if (arr[i] % factorsOfSmallestNum[j] == 0)
                        {
                            gcd = factorsOfSmallestNum[j] < gcd ? factorsOfSmallestNum[j] : gcd;
                        }
                    }
                }
            }
            return gcd;
        }
        // METHOD SIGNATURE ENDS

        //Find the smallest number in an array
        private int findSmallest(int[] arr)
        {
            int smallestNum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallestNum)
                {
                    smallestNum = arr[i];
                }
            }
            return smallestNum;
        }

        //find all factors of the smallest number in the array
        private int[] findFactors(int num)
        {
            List<int> factors = new List<int>();
             for (int i = 1; i <= num; ++i)
            {
                if (num % i == 0)
                {
                    factors.Add(i);
                }
            }
            int[] factorsArr = factors.ToArray();
            Array.Reverse(factorsArr);
            return factorsArr;
        }
    }
}