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
            int setSize = 13;
            string series = "731671765313306249192251196744265747423553491949349698352031277450632623957831801698480186947885184385861560789112949495459501737958" +
                            "3319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766" +
                            "1428280644448664523874930358907296290491560440772390713810515859307960866701724271218839987979087922749219016997208880937766572733300105336788122" +
                            "0235421809751254540594752243525849077116705560136048395864467063244157221553975369781797784617406495514929086256932197846862248283972241375657056" +
                            "0574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591" +
                            "2456652947654568284891288314260769004224219022671055626321111109370544217506941658960408071984038509624554443629812309878799272442849091888458015" +
                            "61660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            Console.WriteLine("The Answer to the Largest Product in Series Euler problem: " + LargestProductinSeries.solveLergestProductinSeries(setSize, series));
            //int[] arr = { 21, 39, 63, 99, 105 };
            //GCD  gcd = new GCD();
            //Console.WriteLine(" the answer: " + gcd.findGCD(5, arr));

            //int[] state = { 1, 0, 1, 1, 0, 1, 0, 0};
            //houses houseState = new houses();
            //int[] answerArr =  houseState.cellCompete(state, 6);
            //Console.Write(" the answer: ");
            //for (int i = 0; i < answerArr.Length; i++)
            //{
            //    Console.Write(answerArr[i]);
            //}
            //Console.Write(" \n");


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
