using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    static class Utils
    {
        public static bool isPalindrome(string productString)
        {
            char[] charArray = productString.ToCharArray();
            Array.Reverse(charArray);
            string reverseProductString = new string(charArray);
            return productString.Equals(reverseProductString);
        }

        public static bool isPrime(long numToCheck)
        {
            int num = 0;
            for (int i = 1; i <= numToCheck; i++)
            {
                if (numToCheck % i == 0)
                {
                    num++;
                }
            }
            if (num == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * used by sorting algorithms to swap two data values at positions m and n in a given integer array
         */
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        /*
         * Bubble Sort
         * Big O = O(N^2)
         */
        public static void IntArrayBubbleSort(int[] data)
        {
            for (int j = data.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
        }

        /*
         * SelectionSort
         * Big O = O(N^2)
         */
        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }

        public static void IntArraySelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    exchange(data, i, k);
            }
        }

        /*
         * Insertion Sort
         * Big O = O(N^2)
         */
        public static void IntArrayInsertionSort(int[] data)
        {
            for (int j = 1; j < data.Length; j++)
            {
                for (int i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
                }
            }
        }
        /*
         * Quick Sort
         * Big O = O(N^2) worst case
         * Big O = O(NlogN) best case
         */
        public static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }
        public static void IntArrayQuickSort(int[] data, int left, int right)
        {
            int pivot;
            int i = left;
            int j = right;

            pivot = data[(left + right) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < pivot)
                    i++;
                while (pivot < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (left < j)
                IntArrayQuickSort(data, left, j);
            if (i < right)
                IntArrayQuickSort(data, i, right);
        }
    }
}
