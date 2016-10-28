using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Rotate Matrix: Given an image reprented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place?
     */ 
    class Array_RotateMatrix
    {

        public static void DoTest(int n)
        {
            int[,] matrix = GenerateMatrix(n);
            DisplayMatrix(matrix);
            if (Rotate(matrix)) DisplayMatrix(matrix);
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            int n = (int)Math.Sqrt((double)matrix.Length);
            for (int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j < n - 1)
                        Console.Write(";");
                    else
                        Console.WriteLine("");
                }

            }
        }

        public static int[,] GenerateMatrix(int n)
        {
            int seed = (int)DateTime.Now.Millisecond;
            Random rnd = new Random(seed);
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, n*n);
                }
            }
            return matrix;
        }

        public static bool Rotate(int[,] matrix)
        {
            int n = (int)Math.Sqrt((double)matrix.Length);
            for (int layer = 0; layer < n/2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i-first;
                    int top = matrix[first,i];

                    matrix[first, i] = matrix[last - offset,first];

                    matrix[last - offset, first] = matrix[last, last - offset];

                    matrix[last, last - offset] = matrix[i,last];

                    matrix[i, last] = top;
                }

            }
            return true;
        }
    }
}
