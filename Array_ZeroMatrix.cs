using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0
     */
    class Array_ZeroMatrix
    {
        public static void ZeroMatrix(int[][] matrix)
        {
            if (matrix == null) return;

            int m = matrix.Length, n = matrix[0].Length;
            bool[] rowFlags = new bool[m];
            bool[] colFlags = new bool[n];

            for (int i = 0; i < m; i++)
            {
                if (rowFlags[i]) continue;
                for (int j = 0; j < n; j++)
                {
                    if (colFlags[j]) continue;
                    if (matrix[i][j] == 0)
                    {
                        rowFlags[i] = true;
                        colFlags[j] = true;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                if (rowFlags[i])
                {
                    for (int j=0; j<n; j++)
                        matrix[i][j] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (colFlags[i])
                {
                    for (int j = 0; j < m; j++)
                        matrix[i][j] = 0;
                }
            }
        }
    }
}
