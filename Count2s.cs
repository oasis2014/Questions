using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Count2s
    {
        public static int FindCount2s(int n)
        {
            /*
             *   Write a method to count the number of 2’s between 0 and n. EXAMPLE input: 35 output: 14 [list of 2’s: 2, 12, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 32]
             *   */
            if (n <= 0) return -1;
            int counter = 0;
            for (int i=1; i<=n; i++)
            {
                if (i.ToString().Contains("2"))
                {
                    counter++;
                    Console.WriteLine(i);
                }
            }
            return counter;
        }

        public static void Get2sCount(int n)
        {
            Console.WriteLine(string.Format("From 0 to {0} Count 2s = {1}", n, FindCount2s(n).ToString()));
            Console.ReadLine();
        }
    }
}
