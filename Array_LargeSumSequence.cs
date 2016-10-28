using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*
     * You are given an array of integers (both positive and negative). Find the continuous sequence with the largest sum. Return the sum.- Kadan's algorithm
     * */
    class Array_LargeSumSequence
    {
        public static void DoTest()
        {
            Console.WriteLine("The input has no item");
            int[] test1 = new int[0];
            int result1 = FindLargestSum(test1);
            Console.WriteLine("The result of the largest sum is {0,3}", result1);

            Console.WriteLine("The input has one item, 1");
            int[] test2 = new int[] { 1 };
            int result2 = FindLargestSum(test2);
            Console.WriteLine("The result is {0,3}", result2);

            Console.WriteLine("The input has the following items");
            int[] test3 = new int[] { 1,2,5,-9,3 };
            int result3 = FindLargestSum(test3);
            Console.WriteLine("The result is {0,3}", result3);

            Console.WriteLine("The input has the following items");
            int[] test4 = new int[] { 1, 2, -9, 3,5 };
            int result4 = FindLargestSum(test4);
            Console.WriteLine("The result is {0,3}", result4);

            Console.WriteLine("The input has the following items");
            int[] test5 = new int[] { 1, 2, -1, 3, -10,4 };
            int result5 = FindLargestSum(test5);
            Console.WriteLine("The result is {0,3}", result5);
        }

        /// <summary>
        /// Find the continuous sequence with the largest sum.
        /// </summary>
        /// <param name="input">assum the input has at least one item</param>
        /// <returns>sum</returns>
        public static int FindLargestSum(int[] input)
        {
            if (input.Length == 1) return input[0];
            int result = 0, sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
                if (result < sum)
                    result = sum;

                if (sum < 0)
                    sum = 0;
            }
            return result;
        }
    }
}
