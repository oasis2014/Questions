using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Questions
{
    /// <summary>
    /// Write a method to generate the nth Fibonacci number 
    /// </summary>
    class FibonacciNumber
    {
        /* * F_n = F_{n-1} + F_{n-2},\!\,
        with seed values[1][2]

        F_1 = 1,\; F_2 = 1

        or[4]

        F_0 = 0,\; F_1 = 1.
         * */
        public static int GetAFibonacciNumber_rec(int n)
        {
            if (n < 0) return -1;
            else if (n == 0) return 0;
            else if (n == 1 || n == 2) return 1;
            else return GetAFibonacciNumber_rec(n - 1) + GetAFibonacciNumber_rec(n - 2);
        }

        public static int GetAFibonacciNumber_iter(int n)
        {
            if (n < 0) return -1;
            if (n == 0) return 0;
            if (n == 1) return 1;

            int fn_1 = 1, fn_2 = 0, fn = 1;
            for (int i = 2; i <= n; i++)
            {
                fn = fn_1 + fn_2;
                fn_2 = fn_1;
                fn_1 = fn;
            }
            return fn;
        }

        public static void FindNthFibonacci_iter(int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int fibonacci = FibonacciNumber.GetAFibonacciNumber_iter(n);
            stopwatch.Stop();
            Console.WriteLine(string.Format("The nth Fibonacci:{0}, ticks:{1}", fibonacci, stopwatch.ElapsedTicks.ToString()));
            Console.WriteLine("The nth Fibonacci:" + fibonacci);
            Console.ReadLine();
        }

        public static void FindNthFibonacci_rec(int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int fibonacci = FibonacciNumber.GetAFibonacciNumber_rec(n);
            stopwatch.Stop();
            Console.WriteLine(string.Format("The nth Fibonacci:{0}, ticks:{1}",fibonacci, stopwatch.ElapsedTicks.ToString()));
            Console.ReadLine();
        }

        public static void PrintNFibonacci(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(string.Format("{0}th fibonacci:{1}\n",i, GetAFibonacciNumber_rec(i)));
            }
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(string.Format("{0}th fibonacci:{1}\n", i, GetAFibonacciNumber_iter(i)));
            }
            Console.ReadLine();
        }
    }
}
