using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            BitManipulation_RealNumberBinaryRepresentation.DoTest(0.75);
            BitManipulation_RealNumberBinaryRepresentation.DoTest(0.72);
            /*
            BitManipulation_InsertMToN.DoTest(19, 1100, 2, 6);
             * */
            /*
            int[] input = new int[] { 0, 2, 1, 4, 5, 6 };
            MissingItemInArray.DoTest(input, 6);
             * */
            /*
            int[] input = new int[] { -2, -1, 0, 3, 5, 6, 7, 9, 13, 14 };
            int value = 12;
            AllPairsSumToSpecificValue.DoTest(input, value);
             * */
            /*
            int[] input = new int[] {2, -8, 3, -2, 4, -10};
            ContinuousSequenceSum.TestResult(input);
            int[] input1 = new int[] { 10 };
            ContinuousSequenceSum.TestResult(input1);
             * */
            /*
            int[] input = new int[10] {1,3,5,7,9,2,4,6,8,10};
            ChangeArray.DoTest(input);

            int[] input1 = new int[8] { 1, 3, 5, 7, 2, 4, 6, 8 };
            ChangeArray.DoTest(input1);
             * */
            //PrimeNumbers.FindLCM(10, 12);
            //FibonacciNumber.FindNthFibonacci_iter(10);
            //FibonacciNumber.FindNthFibonacci_rec(10);
            //FibonacciNumber.PrintNFibonacci(10);
            //Count2s.Get2sCount(35);
            //TwoLinesIntersect.TestIntersectTwoLines();
            //FindKthNumber.FindKth(10);
            //FindKthNumUsingQueue.FindKthNumber(10);
            //CreateBinaryTree.CreateBinaryTreeQuestion();
            //FindFirstCommonNode.AnswerQuestion();
            //GraphQuestion.AnswerQuestion();
            //CreateBinaryTree.PrintPathsUpToGivenSum();
            /*
            int[] input = { 1, 3, 5,7,9, 2, 4, 6,8,10 };
            input = ChangeArray.ChangeArrayOrder2(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }*/

            string s = "abababcda";
            s = Array_RemoveDuplicate.RemoveDuplicate(s);
            string s1 = "baaabcaab";
            s1 = Array_RemoveDuplicate.RemoveDuplicate(s1);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            s = "aaababcda";
            s = Array_RemoveDuplicate.removeDuplicates(s);
            Console.WriteLine(s);

                Console.ReadLine();
        }
    }
}
