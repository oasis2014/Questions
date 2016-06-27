using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /// <summary>
    /// Suppose we have an array a1, a2, ..., an, b1, b2, ..., bn. Implement an algorithm to change this array to a1, b1, a2, b2, ..., an, b
    /// </summary>
    class ChangeArray
    {
        public static void DoTest(int[] input)
        {
            Console.WriteLine("The original array:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0,3}", input[i]);
            }
            DevideConque(input, 0, input.Length - 1);
            Console.WriteLine();
            Console.WriteLine("The shuffled array:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0,3}", input[i]);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Shuffle an array using Devide and Conque method
        /// </summary>
        /// <param name="input">the array</param>
        /// <param name="s">int</param>
        /// <param name="e">int</param>
        public static void DevideConque(int[] input, int s, int e)
        {
            if (input == null)
                return;
            if (input != null && input.Length < 2)
                return;

            if (s < 0 || e < 0 || (s > 0 && e > 0 && s > e))
                return;

            int len = e - s + 1, mid = len / 2, n3 = mid / 2;
            if (mid == 1)
            {
                return;
            }

            if (mid % 2 == 1)
            {
                int temp = input[s+mid - 1];
                for (int i = s + mid - 1; i < s+len - 2; i++)
                {
                    input[i] = input[i + 1];
                }
                input[len - 2] = temp;
                len = len - 2;
                mid = len / 2;
                n3 = mid / 2;
            }

            for (int i =s + n3,j=s + mid; i < s+mid; i++,j++)
            {
                int temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }
            DevideConque(input, s, s+mid-1);
            DevideConque(input, s+mid, s+len-1);
        }
        /// <summary>
        /// Suppose we have an array a1, a2, ..., an, b1, b2, ..., bn. Implement an algorithm to change this array to a1, b1, a2, b2, ..., an, b
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] ChangeArrayOrder(int[] input)
        {
            int len=input.Length, mid=len/2;
            int temp=0;
            for (int i = 0, j=1; i < mid; i++, j+=2)
            {
                temp = input[mid+i];
                RightRotateArray(input, j, mid+i);
                input[j] = temp;
            }
            return input;
        }

        private static void RightRotateArray(int[] input, int s, int e)
        {
            if (s>=e)
                return;

            for (int i = e; i >= s; i--)
            {
                input[i] = input[i - 1];
            }
        }
    }
}
