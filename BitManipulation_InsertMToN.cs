using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*
     * You are given two 32-bit numbers, N and M, and a two bit positions, i and j. Write a method to set all bits between i and j in N equal to M (eg, M becomes a substring of N located at i and starting j).  
     * */
    class BitManipulation_InsertMToN
    {
        public static void DoTest(int M, int N, int i, int j)
        {
            Console.WriteLine("Originally, the M={0,3} N={1,3} i={2,3} j={3,3}", Convert.ToString(M, 2), Convert.ToString(N, 2), i, j);
            int retVal=InsertMtoN(M, N, i, j);
            Console.WriteLine("After insertion, the retVal={0,3}", Convert.ToString(retVal, 2));
        }
        public static int InsertMtoN(int M, int N, int i, int j)
        {
            if (i < 0 || j < 0) return N;
            if (M >= N) return N;
            if (i >= j) return N;

            int allOnes = ~0;
            int M_left = allOnes << j + 1;
            int M_right = 1 << i - 1;
            int M_mask = M_left | M_right;

            N = N & M_mask;
            return M << i | N;
        }
    }
}
