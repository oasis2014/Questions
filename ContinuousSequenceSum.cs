using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class ContinuousSequenceSum
    {
        /*
         * You are given an array of integers (both positive and negative). Find the continuous sequence with the largest sum. Return the sum. 
         * */
        public static int FindContSeqSum(int[] input)
        {
            if (input == null) return 0;
            int len = input.Length;
            if (len == 0) return 0;

            int sum = 0, result = 0;

            for (int i = 0; i < len; i++)
            {
                sum += input[i];
                if (sum > 0 && sum > result)
                {
                    result = sum;
                }
                else if (sum<0)
                {
                    sum = 0;
                }
            }
            return result;
        }

        public static void TestResult(int[] input)
        {
            Console.WriteLine("The integer array:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0,3}", input[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The output is {0,3}", FindContSeqSum(input));
        }
    }
}
