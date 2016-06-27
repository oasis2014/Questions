using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /* An array A[1...n] contains all the integers from 0 to n except for one number which is missing. In this problem, we cannot access an entire integer in A with a single operation. The elements of A are represented in binary, and the only operation we can use to access them is “fetch the jth bit of A[i]”, which takes constant time. Write code to find the missing integer. Can you do it in O(n) time?
     */
    class MissingItemInArray
    {
        public static void DoTest(int[] input, int n)
        {
            Console.WriteLine("The array is ");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0,3}", input[i]);
            }
            Console.WriteLine();
            int missing = FindMissingNum(input, n);
            Console.WriteLine("The missing number is:{0,3}", missing);
        }
        public static int FindMissingNum(int[] input, int n)
        {
            int missing=-1;
            bool[] Existed = new bool[input.Length + 1];
            for (int i = 0; i < n; i++)
            {
                Existed[GetNumber(input, i)] = true;
            }
            for (int i = 0; i < n; i++)
            {
                if (Existed[i] == false)
                    missing = i;
            }
            return missing;
        }

        private static int GetNumber(int[] input, int i)
        {
            int retVal = 0;
            for (int j = 31; j >= 0; j--)
            {
                retVal = (retVal << 1) | fetch(input, i, j);
            }
            return retVal;
        }

        private static int fetch(int[] input, int i, int j)
        {
            return (input[i] >> j) & 1;
        }

        //private static byte[] ConvertIntArrayToByteArray(int[] input)
        //{
            
        //}

    }
}
